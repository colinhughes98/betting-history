using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common;

namespace BettingAPI.Models
{
    public class FixtureDetailsModel
    {
        public int ID { get; set; }
        public string Fixture { get; set; }
        public IEnumerable<MarketDetailsModel> MarketDetails { get; set; }        
    }
}
