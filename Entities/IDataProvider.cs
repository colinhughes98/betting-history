using System.Threading.Tasks;

namespace Entities
{
    public interface IDataProvider
    {
        Task<bool> Update();
        Task<MarketDetails> GetDataFromDB(int id);
    }
}
