using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FixtureDetails
    {
        public int ID { get; set; }
        public string Fixture { get; set; }
        public IEnumerable<MarketDetails> MarketDetails { get; set; }        
    }
}
