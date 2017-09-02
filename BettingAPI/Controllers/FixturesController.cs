using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.BaseController;
using BettingAPI.Models;

namespace BettingAPI.Controllers
{
    [RoutePrefix("api/v1/fixtures")]
    public class FixturesController : BaseApiController
    {
        private readonly IFixturesSerivce _fixtures;
        //private readonly IFixturesHandler _fixtures;

        //public FixturesController(IFixturesHandler fixtures)
        //{
        //    _fixtures = fixtures;
        //}

        public FixturesController(IFixturesSerivce fixtures)
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
            catch (Exception)
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
                var fixture = _fixtures.GetFixture(id);
                var getAll = TheModelFactory.Create(fixture);
                return Ok(getAll);
            }
            catch (Exception)
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
            catch (Exception)
            {
                return NotFound();
            }

        }
    }
  
}
