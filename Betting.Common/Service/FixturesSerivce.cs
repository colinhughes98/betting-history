using System;
using System.Collections.Generic;
using Betting.Common.Interfaces;
using Betting.Common.Models;

namespace Betting.Common.Service
{
    public class FixturesSerivce : IFixturesSerivce
    {
        private readonly IDataProvider _dataProvider;

        public FixturesSerivce(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        //public BettingDetailsModel GetTheBets()
        //{            
        //    //var hist =  _dataProvider.GetAllBetsHistory();
        //    //if (hist == null) throw new Exception();

        //    //var bettingDetailsModel = new List<BettingDetailsModel>();

        //    //while (hist.Read())
        //    //{
        //    //   BettingDetailsModel bdm = new BettingDetailsModel
        //    //   {
        //    //       FirstName = Convert.ToString(hist[""])
        //    //   }
        //    //}
        //    return new BettingDetailsModel() { FirstName = "Col", Surname = "Hughes" };
        //}

        //public BettingDetailsModel GetTheBets(int id)
        //{
        //    return new BettingDetailsModel();
        //}

        public IEnumerable<FixtureDetailsModel> GetTheFixtures()
        {            
            var fixtureList = new List<FixtureDetailsModel>();

            try
            {
                fixtureList = (List<FixtureDetailsModel>) _dataProvider.GetAllFixtures();                
            }
            catch (Exception)
            {
                throw;
            }
            
            return fixtureList;
        }

        public FixtureDetailsModel GetFixture(int id)
        {
            var fixture = _dataProvider.GetFixture(id);

            FixtureDetailsModel fdm = new FixtureDetailsModel();

            while (fixture.Read())
            {
                fdm.Description = Convert.ToString(fixture["Description"]);
                fdm.ID = Convert.ToInt32(fixture["ID"]);
            }

            return fdm;
        }

        public bool AddFixture(AddFixtureModel model)
        {
            var response = _dataProvider.AddFixture(model);
            int? id = null;
            while (response.Read())
            {
                id = Convert.ToInt32(response["ID"]);
            }

            return id != null;
        }
    }
}
