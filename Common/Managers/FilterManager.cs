using System;
using Common.Models;

namespace Common.Managers
{
    public class FilterManager : IFilterManager
    {
        private IExtractionsManager m_extractionsManager;

        public FilterManager(IExtractionsManager extractionsManager)
        {
            m_extractionsManager = extractionsManager ?? throw new ArgumentNullException(nameof(extractionsManager), "The extractionsManager is null");
        }

        public int GetChancePercentage(ExtractionModel model)
        {
            return 0;
        }
    }
}