using CsvHelper.Configuration.Attributes;

namespace Common.Models
{
    public class ExtractionModel
    {
        [Name("Date")]
        public System.DateTime DateTime { get; set; }
        [Name("N1")] 
        public string N1 { get; set; }
        [Name("N2")]
        public string N2 { get; set; }
        [Name("N3")]
        public string N3 { get; set; }
        [Name("N4")]
        public string N4 { get; set; }
        [Name("N5")]
        public string N5 { get; set; }
        [Name("N6")]
        public string N6 { get; set; }
    }
}