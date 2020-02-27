using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Common.Models;
using Common.Properties;
using CsvHelper;

namespace Common.Managers
{
    internal class ExtractionsManager : IExtractionsManager, ICsvManager
    {
        public IEnumerable<ExtractionModel> Extractions { get; private set; }

        public async Task LoadDataFromCsvAsync()
        {
            Extractions = await Task.Run(() =>
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