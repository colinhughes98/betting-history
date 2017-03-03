using System.Threading.Tasks;

namespace Betting.Common
{
    public interface IHistory
    {
        BettingDetails GetAllBets();
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
