using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common.Interfaces;

namespace Betting.Common.Models
{
    public class Repository : IRepository
    {
        private readonly IDataProvider dataProvider;
        public Repository(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public async Task<BettingDetailsModel> GetTheBetsAsync()
        {
            var hist = await dataProvider.GetAllBetsHistoryAsync();
            if (hist == null) throw new Exception();

            while (hist.Read())
            {
                //todo: read data
            }
            return new BettingDetailsModel();// { FirstName = hist.FirstOrDefault(), Surname = hist.LastOrDefault() };
        }

        public BettingDetailsModel GetTheBets(int id)
        {
            return new BettingDetailsModel();
        }
    }
}
