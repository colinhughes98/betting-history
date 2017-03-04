using System.Threading.Tasks;
using System.Web.Http;
using Betting.Common.Models;

namespace Betting.Common.Interfaces
{
    public interface IModelFactory<out T>
    {
        T Create(string action);
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
