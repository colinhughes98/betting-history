using System.Threading.Tasks;
using Betting.Common.Models;

namespace Betting.Common.Interfaces
{
    public interface IHistory
    {
        BettingDetailsModel GetAllBets();
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
