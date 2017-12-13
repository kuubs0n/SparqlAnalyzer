using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SparqlAnalyzer.General
{
    public class QueryAnalizer
    {
        private readonly IDictionary<string, string> _queryRules = new Dictionary<string, string>
        {
            {@"^.*(select|ask|construct|describe).*$", "Missing query type eg. select in query"},
            {@"^.*select\s+(\*\s+|\?[a-z0-9]+).*$", "Missing item?"},
            {@"^\s*((select|ask|construct).+where|describe.+where?).*$", "Missing where in query"},
            {@"^.+where\s+\{.*\}.*$", "Missing quarters in where"},
            {
                @"^.+where\s+\{\s*(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)[a-zA-Z0-9]+\s*){3}\.?\s*\}.*",
                "Incorrect triples"
            },
            {
                @"^.+where\s+\{\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+){3}\s*\;\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+){2}\}.*$",
                "Character „;” is used for triples with common subject. Use „.” for separated triples or after „;” write only predicate and object"
            }
        };

        private readonly string _query;

        public QueryAnalizer(string query)
        {
            _query = query.ToLower();
        }

        public AnalyzeResult AnalyzeQuery()
        {
            AnalyzeResult results = new AnalyzeResult();
            ICollection<string> errorMessages = new List<string>();

            foreach (KeyValuePair<string, string> rule in _queryRules)
            {
                if (!Regex.IsMatch(_query, rule.Key))
                {
                    results.IsCorrectQuery = false;
                    errorMessages.Add(rule.Value);
                }
            }
            results.ErrorMessages = errorMessages;

            return results;
        }
    }
}
