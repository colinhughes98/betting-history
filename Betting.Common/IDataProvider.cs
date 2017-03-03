using System.Collections;
using System.Data;
using System.Threading.Tasks;

namespace Betting.Common
{
    public interface IDataProvider
    {
        //Task<bool> UpdateAsync();
        //Task<DataSet> GeBetsFromDBAsync(int id);
        Task<IEnumerable> GetAllBetsHistoryAsync();
    }
}
