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
            // var fixtures = _dataProvider.GetAllFixtures();
            var fixtureList = new List<FixtureDetailsModel>();

            //var fixtures = _dataProvider.DataAccressExecuteReader("BettingHistory.dbo.GetListOfFixtures");
            var fixtures = _dataProvider.GetAllFixtures();

            if (fixtures == null) return fixtureList;

            while (fixtures.Read())
            {
                FixtureDetailsModel fdm = new FixtureDetailsModel()
                {
                    Description = Convert.ToString(fixtures["Description"]),
                    ID = Convert.ToInt32(fixtures["ID"])
                };
                fixtureList.Add(fdm);
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
