using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common.Interfaces;
using Betting.Common.Models;

namespace Betting.Common.Handlers
{
    public class FixturesHandler : IFixturesHandler
    {
        private readonly IRepository _repo;

        public FixturesHandler(IRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<FixtureDetailsModel> GetTheFixtures()
        {
            return _repo.GetTheFixtures();
        }

        public FixtureDetailsModel GetTheFixture(int id)
        {
            return id < 1 ? new FixtureDetailsModel() : _repo.GetFixture(id);
        }

        public bool AddFixture(AddFixtureModel model)
        {
            return _repo.AddFixture(model);
        }
    }
}
