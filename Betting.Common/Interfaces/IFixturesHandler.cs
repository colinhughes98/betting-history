using System.Collections.Generic;
using Betting.Common.Models;

namespace Betting.Common.Interfaces
{
    public interface IFixturesHandler
    {
        IEnumerable<FixtureDetailsModel> GetTheFixtures();
        FixtureDetailsModel GetTheFixture(int id);
        bool AddFixture(AddFixtureModel model);
    }
}
