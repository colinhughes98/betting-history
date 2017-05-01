using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common.Models;

namespace Betting.Common.Interfaces
{
    public interface IRepository
    {
        BettingDetailsModel GetTheBets();

        BettingDetailsModel GetTheBets(int id);

        IEnumerable<FixtureDetailsModel> GetTheFixtures();

        FixtureDetailsModel GetFixture(int id);
    }
}
