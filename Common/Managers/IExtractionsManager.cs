using System.Collections.Generic;
using Common.Models;

namespace Common.Managers
{
    public interface IExtractionsManager
    {
        IEnumerable<ExtractionModel> Extractions { get; }
    }
}