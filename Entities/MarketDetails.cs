using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{   
    public class MarketDetails
    {
        public int ID { get; set; }
        public int FixtureId { get; set; }
        public string Market { get; set; }
        public decimal BookiesOdds { get; set; }
        public decimal Stake { get; set; }
        public int Result { get; set; }
        public string FinalScore { get; set; }
        public decimal MyOdds { get; set; }
        public decimal Return { get; set; }
    }    
}
