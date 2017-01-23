using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class BettingHistory
    {
        private readonly IDataProvider dataProvider;

        public BettingHistory()
        {
           dataProvider = new DataProvider();
        }
        public void AllBets()
        {
            
        }

        public async Task<MarketDetails> GetBet(int id)
        {
            var marketData = await dataProvider.GetDataFromDB(id);

            return marketData;
        }

        public async Task AddBet()
        {
            await dataProvider.Update();
        }
    }
}
