using System.Threading.Tasks;

namespace Entities
{
    public interface IDataProvider
    {
        Task<bool> Insert();
        Task<MarketDetails> GetDataFromDB(int id);
    }
}
