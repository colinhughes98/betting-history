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
            var hist =  _dataProvider.GetAllBetsHistory();
            if (hist == null) throw new Exception();

            //while (hist.Read())
            //{
            //    //todo: read data
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
    }
}
