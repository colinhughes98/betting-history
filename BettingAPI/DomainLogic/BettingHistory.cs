using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Betting.Common;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Models;
using DAL;

namespace BettingAPI.DomainLogic
{
    public class BettingHistory : IHistory
    {
        private readonly IDataProvider dataProvider;

        public BettingHistory(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public BettingDetailsModel GetAllBets()
        {                        
            var hist =  dataProvider.GetAllBetsHistory();

            return new BettingDetailsModel {FirstName = hist.FirstOrDefault(), Surname = hist.LastOrDefault()};
        }      
    }
}
