using System;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;


namespace SparqlAnalyzer
{
    public partial class Form1 : Form
    {
        private static readonly string RDFUrl = @"http://dbpedia.org/sparql";
        
        public Form1()
        {
            InitializeComponent();

            IGraph graph = new Graph();
            UriLoader.Load(graph, new Uri(RDFUrl));

            try
            {
                Object results = graph.ExecuteQuery("SELECT * WHERE {\r\n  ?sub ?pre ?dupa.\r\n} \r\nLIMIT 10");
                if (results is SparqlResultSet)
                {
                    //SELECT/ASK queries give a SparqlResultSet
                    SparqlResultSet rset = (SparqlResultSet)results;
                    foreach (SparqlResult r in rset)
                    {
                        //Do whatever you want with each Result
                    }
                }
                else if (results is IGraph)
                {
                    //CONSTRUCT/DESCRIBE queries give a IGraph
                    IGraph resGraph = (IGraph)results;
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
            }
            catch (RdfQueryException queryEx)
            {
                //There was an error executing the query so handle it here
                Console.WriteLine(queryEx.Message);
            }
        }
    }
}
