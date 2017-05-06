using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.DomainLogic;
using BettingAPI.Models;

namespace BettingAPI.Controllers
{
    [RoutePrefix("api/v1/fixtures")]
    public class FixturesController : BaseApiController
    {
        private readonly IFixturesHandler _fixtures;

        public FixturesController(IFixturesHandler fixtures)
        {
            _fixtures = fixtures;
        }

        [HttpGet]
        [Route("", Name = "GetAllFixtures")]
        public IHttpActionResult GetAllFixtures()
        {
            try
            {
                var fixtures = _fixtures.GetTheFixtures();
                var getAll = TheModelFactory.Create(fixtures);
                return Ok(getAll);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            
        }

        [HttpGet]
        [Route("fixture/{id}", Name = "GetFixture")]
        public IHttpActionResult GetAFixture(int id)
        {
            try
            {
                var fixture = _fixtures.GetTheFixture(id);
                var getAll = TheModelFactory.Create(fixture);
                return Ok(getAll);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [HttpPost]
        [Route("", Name = "AddFixture")]
        public IHttpActionResult AddFixture([FromBody] AddFixtureModel fixture)
        {
            try
            {
               var response = _fixtures.AddFixture(fixture);

                return response ? (IHttpActionResult) Ok() : BadRequest();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }
    }

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

    public interface IFixturesHandler
    {
        IEnumerable<FixtureDetailsModel> GetTheFixtures();
        FixtureDetailsModel GetTheFixture(int id);
        bool AddFixture(AddFixtureModel model);
    }
}
