// FILE: Models/OopConcept.cs
namespace SOFT121.Models // << NEW: Wrap the class in the project namespace
{
    using System;

    public class OopConcept
    {
        // ... (rest of the class content remains the same) ...
        public string Term { get; set; }
        public string Definition { get; set; }
        private string _privateDetail; 

        public OopConcept(string term, string definition, string privateDetail)
        {
            Term = term;
            Definition = definition;
            _privateDetail = privateDetail;
        }

        public string Summarize()
        {
            return $"**{Term}**: {Definition}";
        }
    }
}
