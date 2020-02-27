using System.Threading.Tasks;

namespace Common.Managers
{
    public interface ICsvManager
    {
        Task LoadDataFromCsvAsync();
    }
}
