using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Routing;
using Betting.Common;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.DomainLogic;
using BettingAPI.Enums;

namespace BettingAPI.Controllers
{    
    [RoutePrefix("api/v1/bet")]
    public class BetController : BaseApiController
    {
        public BetController(IRepository repo):base(repo)
        {
        }

        [HttpGet]
        [Route("", Name = "GetAllBets")]
        public IHttpActionResult GetAllBets()
        {
            try
            {
                var bets = TheRepository.GetTheBets();
                var getAll = TheModelFactory.Create(bets);
                return Ok(getAll);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }    
}
