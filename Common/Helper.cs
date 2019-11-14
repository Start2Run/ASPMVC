using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Common
{
    public static class Helper
    {
        public static IEnumerable<Models.ExtractionModel> LoadDataFromCSv(string filePath)
        {
            List<Models.ExtractionModel> records;
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader))
            {
                records = csv.GetRecords<Models.ExtractionModel>().ToList();
            }
            return records;
        }
    }
}
