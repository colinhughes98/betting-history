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
        private readonly IDataProvider _dataProvider;
        public Repository(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public BettingDetailsModel GetTheBets()
        {            
            //var hist =  _dataProvider.GetAllBetsHistory();
            //if (hist == null) throw new Exception();

            //var bettingDetailsModel = new List<BettingDetailsModel>();

            //while (hist.Read())
            //{
            //   BettingDetailsModel bdm = new BettingDetailsModel
            //   {
            //       FirstName = Convert.ToString(hist[""])
            //   }
            //}
            return new BettingDetailsModel() { FirstName = "Col", Surname = "Hughes" };
        }

        public BettingDetailsModel GetTheBets(int id)
        {
            return new BettingDetailsModel();
        }

        public IEnumerable<FixtureDetailsModel> GetTheFixtures()
        {
            var fixtures = _dataProvider.GetAllFixtures();

            var fixtureList = new List<FixtureDetailsModel>();
            
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
    }
}
