﻿using System;
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

        public Task<BettingHistory> GetAllBetsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<FixtureDetails> GetBetAsync(int id)
        {
            FixtureDetails fd = new FixtureDetails();            
            var fixtureData = await dataProvider.GeBetsFromDBAsync(id);

            if (fixtureData != null && fixtureData.Tables.Count > 0)
            {
                var table = fixtureData.Tables[0];

                fd.ID = Convert.ToInt32(table.Rows[0]["Id"]);
                fd.MarketDetails = new[]{new MarketDetails(){ BookiesOdds = 2M, FinalScore = "2-1"}};
            }
            return fd;
        }

        public async Task<bool> AddBetAsync()
        {
           return await dataProvider.UpdateAsync();
        }           
    }    
}
