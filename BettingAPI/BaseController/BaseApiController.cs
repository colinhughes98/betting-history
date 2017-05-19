using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Models;
using BettingAPI.Helpers;
using BettingAPI.Models;

namespace BettingAPI.BaseController
{
    public abstract class BaseApiController : ApiController
    {
        private ModelFactory _modelFactory;

        protected ModelFactory TheModelFactory => _modelFactory ?? (_modelFactory = new ModelFactory(Request));
    }

    public class ModelFactory
    {
        private readonly HttpRequestMessage _request;
        private readonly UrlHelper _url;

        public ModelFactory(HttpRequestMessage request)
        {
            _request = request;
            _url = new UrlHelper(_request);
        }

        public GetTheBetsModel Create(BettingDetailsModel bets)
        {
            return new GetTheBetsModel
            {
                Bets = bets,
                URL = _url.Link("GetAllBets", null)
            };
        }

        public IEnumerable<GetTheFixturesModel> Create(IEnumerable<FixtureDetailsModel> fixtures)
        {
            return fixtures.NullSafeIEnumerable().Select(Create).ToList();
        }

        public GetTheFixturesModel Create(FixtureDetailsModel fixture)
        {
            return new GetTheFixturesModel()
            {
                Fixture = fixture.Description,
                URL = _url.Link("GetFixture", new {id = fixture.ID})
            };
        }
    }
}
