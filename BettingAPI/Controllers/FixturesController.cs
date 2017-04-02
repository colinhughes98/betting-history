using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Betting.Common.Interfaces;
using BettingAPI.DomainLogic;

namespace BettingAPI.Controllers
{
    [RoutePrefix("api/v1/fixtures")]
    public class FixturesController : BaseApiController
    {
        public FixturesController(IRepository repo):base(repo)
        {
        }

        [HttpGet]
        [Route("", Name = "GetAllFixtures")]
        public IHttpActionResult GetAllFixtures()
        {
            try
            {
                var fixtures = TheRepository.GetTheFixtures();
                var getAll = TheModelFactory.Create(fixtures);
                return Ok(getAll);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
