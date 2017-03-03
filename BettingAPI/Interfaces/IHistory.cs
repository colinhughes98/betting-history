using System.Threading.Tasks;

namespace BettingAPI.Interfaces
{
    public interface IHistory
    {
        object GetAllBets();
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
