using System.Threading.Tasks;

namespace Betting.Common
{
    public interface IHistory
    {
        object GetAllBets();
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
