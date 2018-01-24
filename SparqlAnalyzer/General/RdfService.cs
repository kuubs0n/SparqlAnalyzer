using System;
using System.Collections.Generic;
using System.Linq;
using VDS.RDF;

namespace SparqlAnalyzer.General
{
    public class RdfService
    {
        private readonly IGraph _graph = new Graph();

        public RdfService(string path, bool isLocal)
        {
            if(isLocal)
                _graph.LoadFromFile(path);
            else
                _graph.LoadFromUri(new Uri(path));
        }

        public IEnumerable<string> GetPossibleRdfArguments()
        {
            var rawParameters = _graph.Triples.PredicateNodes.Select(_ => _.ToString());

            ICollection<string> parameters = new List<string>();

            foreach (var param in rawParameters)
            {
                parameters.Add(param.Split('#')[1]);
            }

            return parameters;
        }

        public string GetCdPrefix()
        {
            return _graph.Triples.PredicateNodes.FirstOrDefault().ToString().Split('#')[0] + "#";
        }
    }
}
