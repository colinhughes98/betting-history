using System.Threading.Tasks;

namespace Entities
{
    public interface IDataProvider<T>
    {
        Task<bool> UpdateAsync();
        Task<T> GetDataFromDBAsync(int id);
    }
}
