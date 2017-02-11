using System;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class BettingHistory : IHistory
    {
        private readonly IDataProvider dataProvider;

        public BettingHistory(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        
        public async Task<FixtureDetails> GetBetAsync(int id)
        {
            FixtureDetails fd = new FixtureDetails();
            var fixtureData = await dataProvider.GeBetsFromDBAsync(id);

            if (fixtureData != null && fixtureData.Tables.Count > 0)
            {
                var table = fixtureData.Tables[0];

                fd.ID = Convert.ToInt32(table.Rows[0]["Id"]);
            }
            return fd;
        }

        public async Task AddBetAsync()
        {
            await dataProvider.UpdateAsync();
        }           
    }    
}
