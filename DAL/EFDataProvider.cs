using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class EFDataProvider : IDataProvider<MarketDetails>
    {
        public async Task<bool> UpdateAsync()
        {
            int save;
            using (var db = new DataModel())
            {
                db.MarketDetailses.Add(new MarketDetails() { ID = 1, BookiesOdds = 2.1M, Market = "Asian Handicap 0" });
                save = await db.SaveChangesAsync();
            }
            return save > -1;
        }
        
        public async Task<MarketDetails> GetDataFromDBAsync(int id)
        {
            MarketDetails m;
            using (var db = new DataModel())
            {
                m = await db.MarketDetailses.FindAsync(id);                
            }
            return m;
        }               
    }
}
