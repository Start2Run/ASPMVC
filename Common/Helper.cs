using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Common.Models;
using Common.Properties;

namespace Common
{
    public static class Helper
    {
        public static async Task<IEnumerable<Models.ExtractionModel>> LoadDataFromCsvAsync()
        {
            return await Task.Run(() =>
             {
                 List<ExtractionModel> records;

                 var stream = Resources.LotoData;
                 if (string.IsNullOrEmpty(stream)) return new List<ExtractionModel>();
                 using (var csv = new CsvReader(new StringReader(stream)))
                 {
                     csv.Configuration.RegisterClassMap<ExtractionModelMap>();
                     csv.Configuration.ReadingExceptionOccurred = ex => true;
                     records = csv.GetRecords<ExtractionModel>().ToList();
                 }

                 return records;
             });
        }
    }
}
