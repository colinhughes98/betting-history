using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common.Interfaces;

namespace Betting.Common.Models
{
    public class SomeBusinessLogicForBets : ITheBets
    {
        private readonly IDataProvider dataProvider;
        public SomeBusinessLogicForBets(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public BettingDetailsModel GetTheBets()
        {
            var hist = dataProvider.GetAllBetsHistory();
            if (hist == null) throw new Exception();

            return new BettingDetailsModel();// { FirstName = hist.FirstOrDefault(), Surname = hist.LastOrDefault() };
        }

        public BettingDetailsModel GetTheBets(int id)
        {
            return new BettingDetailsModel();
        }
    }
}
