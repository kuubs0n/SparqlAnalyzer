using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SparqlAnalyzer.General
{

    public struct QueryRule
    {
        public string startRegex, ruleRegex, errorMessage;

        public QueryRule(string startRegex, string ruleRegex, string errorMessage)
        {
            this.startRegex = startRegex;
            this.ruleRegex = ruleRegex;
            this.errorMessage = errorMessage;
        }
    }


    public class QueryAnalizer
    {
        private readonly QueryRule[] _queryRules = new QueryRule[7]
        {
           new QueryRule(@"^.*$",
                @"^.*(select|ask|construct|describe).*$",
                "Missing query type eg. select in query"),

           new QueryRule(@"^.*select.*$",
               @"^.*select\s+(\*\s+|\?[a-z0-9]+).*$",
               "Missing item?"),

           new QueryRule(@"^\s*(select|ask|construct).*$",
               @"^\s*((select|ask|construct).+where|describe.+where?).*$",
               "Missing where in query"),

         new QueryRule(@"^.+where.*$",
             @"^.+where\s+\{.*\}.*$",
             "Missing quarters in where"),

         new QueryRule(@"^.+where\s+\{\s*(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)[a-zA-Z0-9]+\s*.*$)",
             @"^.+where\s+\{\s*(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)[a-zA-Z0-9]+\s*){3}(\.||\;.*)?\s*\}.*",
                "Incorrect triples"),

         new QueryRule(@"^.+where\s+\{\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+){2}(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+)\s*\;.*$",
             @"^.+where\s+\{\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+){2}(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s*)\s*\;\s*(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+)(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s*)(\;\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+)(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s*))*\.\s*\}.*$",
                "Character „;” is used for triples with common subject. Use „.” for separated triples or after „;” write only predicate and object"),

         new QueryRule(@"^.*(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9] +\s+){2,3}\s*\,.*$",
             @"^.*(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9] +\s+){2,3}\s*\,\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+)(\,\s+(\<[a-zA-Z0-9]+\>\s+|[a-zA-Z0-9]*:[a-zA-Z0-9]+\s+|(\$|\?)?[a-zA-Z0-9]+\s+)*\.\}.*$",
                "Character „,” is used for triples with common subject and predicate. Use „.” for separated triples or after „,” write only object")

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
            results.IsCorrectQuery = true;
            foreach (QueryRule rule in _queryRules)
            {
                if (Regex.IsMatch(_query, rule.startRegex))
                {
                    if (!Regex.IsMatch(_query, rule.ruleRegex))
                    {
                        results.IsCorrectQuery = false;
                        errorMessages.Add(rule.errorMessage);
                    }
                }
            }
            results.ErrorMessages = errorMessages;

            return results;
        }
    }
}
