using System.Data;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDataProvider
    {
        Task<bool> UpdateAsync();
        Task<DataSet> GeBetsFromDBAsync(int id);
        Task<DataSet> GetAllBetsHistoryAsync();
    }
}
