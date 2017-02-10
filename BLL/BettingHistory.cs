using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class BettingHistory : IHistory
    {
        private readonly IDataProvider<MarketDetails> dataProvider;

        public BettingHistory(IDataProvider<MarketDetails> dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        
        public async Task<MarketDetails> GetBetAsync(int id)
        {
            var marketData = await dataProvider.GetDataFromDBAsync(id);

            return marketData;
        }

        public async Task AddBetAsync()
        {
            await dataProvider.UpdateAsync();
        }
           
    }    
}
