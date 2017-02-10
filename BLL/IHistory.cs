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
        Task<MarketDetails> GetBetAsync(int id);
        Task AddBetAsync();
    }
}
