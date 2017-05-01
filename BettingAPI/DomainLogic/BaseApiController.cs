using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Helpers;
using BettingAPI.Models;

namespace BettingAPI.DomainLogic
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
            IList<GetTheFixturesModel> listOfFixtures = new List<GetTheFixturesModel>();

            foreach (var fixtureDetailsModel in fixtures.NullSafeIEnumerable())
            {
                //listOfFixtures.Add(new GetTheFixturesModel()
                //{
                //    Fixture = fixtureDetailsModel.Description,
                //    URL = _url.Link("GetAllFixtures", new { id = fixtureDetailsModel.ID })
                //});

                listOfFixtures.Add(Create(fixtureDetailsModel));
            }
            return listOfFixtures;
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
