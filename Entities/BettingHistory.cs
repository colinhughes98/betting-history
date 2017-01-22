using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BettingHistory
    {
        public int ID { get; set; }
        public int FixtureDetailsID { get; set; }
        public decimal Stake { get; set; }
        public int Result { get; set; }
        public string FinalScore { get; set; }
        public decimal MyOdds { get; set; }
        public decimal Return { get; set; }
    }

    public class MarketDetails
    {
        public int ID { get; set; }
        public string Market { get; set; }
        public decimal BookiesOdds { get; set; }
    }

    public class FixtureDetails
    {
        public int ID { get; set; }
        public string Fixture { get; set; }
        public int MarketDetailsID { get; set; }
    }
}
