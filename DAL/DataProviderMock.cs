using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DataProviderMock : IDataProvider
    {
        public Task<bool> Update()
        {
           return new Task<bool>(()=> true);
        }

        public Task<MarketDetails> GetDataFromDB(int id)
        {
            return new Task<MarketDetails>(() => new MarketDetails() {BookiesOdds = 2, ID = 1, Market = "Asian Handicap"});
        }
    }
}
