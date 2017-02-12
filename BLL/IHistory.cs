using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL
{
    public interface IHistory
    {
        Task<BettingHistory> GetAllBetsAsync();
        Task<FixtureDetails> GetBetAsync(int id);
        Task<bool> AddBetAsync();
    }
}
