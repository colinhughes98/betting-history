using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DataProviderMock : IDataProvider<MarketDetails>
    {
        public Task<bool> Update()
        {
            return new Task<bool>(()=>true);
        }

        public Task<MarketDetails> GetDataFromDBAsync(int id)
        {
            var m = new MarketDetails()
        {
                BookiesOdds = 2,
                ID = 1,
                Market = "Asian Handicap"
            };
            return new Task<MarketDetails>(() => m);
        }
    }
}
