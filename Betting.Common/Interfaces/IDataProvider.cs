using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Betting.Common.Interfaces
{
    public interface IDataProvider
    {
        //Task<bool> UpdateAsync();
        //Task<DataSet> GeBetsFromDBAsync(int id);
        Task<IDataReader> GetAllBetsHistoryAsync();
    }
}
