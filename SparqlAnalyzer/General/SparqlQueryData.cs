namespace SparqlAnalyzer.General
{
    internal class SparqlQueryData
    {
        private readonly string _path;
        private readonly string _query;
        private readonly bool _isRdfLocal;

        internal SparqlQueryData(string path, string query, bool isRdfLocal)
        {
            _path = path;
            _query = query;
            _isRdfLocal = isRdfLocal;
        }

        internal string Path => _path;

        internal string Query => _query;

        internal bool IsIsRdfLocal => _isRdfLocal;
    }
}
