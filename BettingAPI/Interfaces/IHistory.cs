using System.Threading.Tasks;

namespace BettingAPI.Interfaces
{
    public interface IHistory
    {
        Task<dynamic> GetAllBetsAsync();
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
