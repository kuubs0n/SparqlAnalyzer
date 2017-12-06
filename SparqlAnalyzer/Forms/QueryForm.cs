using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Query.Datasets;
using VDS.RDF.Writing.Formatting;

namespace SparqlAnalyzer.Forms
{
    internal partial class QueryForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly SparqlQueryData _queryData;
        private readonly IGraph _graph = new Graph();

        internal QueryForm(SparqlQueryData queryData)
        {
            InitializeComponent();

            _queryData = queryData;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                labelControlQueryString.Text = _queryData.Query;
                progressPanel.Visible = true;
                await PrepareView();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Niepoprawne zapytanie SPARQL", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                progressPanel.Visible = false;
            }
        }

        private Task PrepareView()
        {
            ChangeColumnCaption();
            return Task.Run(() =>
            {
                IEnumerable<ResultData> dataSource = GetResults();
                SetDataSource(dataSource);
                SetQueryResultCount(dataSource);
            });
        }

        private void SetQueryResultCount(IEnumerable<ResultData> dataSource)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new MethodInvoker(() =>
                {
                    SetQueryResultCount(dataSource);
                }));
                return;
            }

            labelControlResultCount.Text = dataSource.Count().ToString();
        }

        private void SetDataSource(IEnumerable<ResultData> dataSource)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new MethodInvoker(() =>
                {
                    SetDataSource(dataSource);
                }));
                return;
            }

            gridControl.DataSource = dataSource;
        }

        private void ChangeColumnCaption()
        {
            string query = _queryData.Query;
            int beginWhereStatement = query.IndexOf("{");
            int endWhereStatement = query.IndexOf("}");
            string whereStatement = query
                .Substring(beginWhereStatement + 1, endWhereStatement - 1 - beginWhereStatement)
                .Replace("\r\n", String.Empty);
            string[] whereStatements = whereStatement.Split('?');

            for (int i = 1; i < whereStatements.Length; i++)
            {
                GridView view = gridControl.DefaultView as GridView;
                view.Columns.ElementAt(i - 1).Caption = whereStatements[i];
            }
        }

        private IEnumerable<ResultData> GetResults()
        {
            ICollection<ResultData> results = new List<ResultData>();
            try
            {
                if (!_queryData.IsIsRdfLocal)
                    _graph.LoadFromUri(new Uri(_queryData.Path));
                else
                    _graph.LoadFromFile(_queryData.Path);

                Object result = _graph.ExecuteQuery(_queryData.Query);
                if (result is SparqlResultSet)
                {
                    //SELECT/ASK queries give a SparqlResultSet
                    SparqlResultSet rset = (SparqlResultSet) result;
                    foreach (SparqlResult r in rset)
                    {
                        int index = 1;
                        ResultData resultData = new ResultData();
                        foreach (KeyValuePair<string, INode> node in r)
                        {
                            switch (index)
                            {
                                case 1:
                                    resultData.Value1 = node.Value.ToString();
                                    break;
                                case 2:
                                    resultData.Value2 = node.Value.ToString();
                                    break;
                                case 3:
                                    resultData.Value3 = node.Value.ToString();
                                    break;
                            }
                            index++;
                        }
                        results.Add(resultData);
                    }
                }
                else if (results is IGraph)
                {
                    //CONSTRUCT/DESCRIBE queries give a IGraph
                    IGraph resGraph = (IGraph) results;
                    foreach (Triple t in resGraph.Triples)
                    {
                        //Do whatever you want with each Triple
                    }
                }
                else
                {
                    //If you don't get a SparqlResutlSet or IGraph something went wrong 
                    //but didn't throw an exception so you should handle it here
                    Console.WriteLine("ERROR");
                }
                return results;
            }
            catch (RdfQueryException queryEx)
            {
            }
            catch (RdfParseException parseEx)
            {
                if (InvokeRequired && !IsDisposed)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        XtraMessageBox.Show(this, "Błąd zapytania SPARQL\r\n" + parseEx.Message);
                    }));
                }
                XtraMessageBox.Show(this, "Błąd zapytania SPARQL\r\n" + parseEx.Message);
            }

            return null;
        }
    }
}