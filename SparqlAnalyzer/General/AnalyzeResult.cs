using System.Collections.Generic;

namespace SparqlAnalyzer.General
{
    public class AnalyzeResult
    {
        public IEnumerable<string> ErrorMessages { get; set; }

        public bool IsCorrectQuery { get; set; }
    }
}
