using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Common.Models
{
    public class ExtractionModel
    {
        [Name("Date")]
        public System.DateTime Date { get; set; }
        [Name("N1")]
        public int N1 { get; set; }
        [Name("N2")]
        public int N2 { get; set; }
        [Name("N3")]
        public int N3 { get; set; }
        [Name("N4")]
        public int N4 { get; set; }
        [Name("N5")]
        public int N5 { get; set; }
        [Name("N6")]
        public int N6 { get; set; }
    }

    public sealed class ExtractionModelMap : ClassMap<ExtractionModel>
    {
        public ExtractionModelMap()
        {
            Map(m => m.Date).TypeConverterOption.Format("mm/dd/yy");
            Map(m => m.N1);
            Map(m => m.N2);
            Map(m => m.N3);
            Map(m => m.N4);
            Map(m => m.N5);
            Map(m => m.N6);
        }
    }
}