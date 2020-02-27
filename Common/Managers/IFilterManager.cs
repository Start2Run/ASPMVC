using Common.Models;

namespace Common.Managers
{
    public interface IFilterManager
    {
        int GetChancePercentage(ExtractionModel model);
    }
}
