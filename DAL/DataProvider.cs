using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DataProvider : IDataProvider
    {
        public Task<bool> Update()
        {
            return Task<bool>.Factory.StartNew(
                UpdateDB);
        }
        
        public Task<MarketDetails> GetDataFromDB(int id)
        {
          return Task<MarketDetails>.Factory.StartNew(()=> DataFromDb(id));
        }

        private  MarketDetails DataFromDb(int id)
        {
            MarketDetails m;
            using (var db = new DataModel())
            {
                m = db.MarketDetailses.SingleOrDefault(a => a.ID == id);
            }
            return m;
        }

        private bool UpdateDB()
        {

            using (var db = new DataModel())
            {
                db.MarketDetailses.Add(new MarketDetails() {ID = 1, BookiesOdds = 2.1M, Market = "Asian Handicap 0"});
                var save = db.SaveChanges();
            }
            return false;
        }
    }


}
