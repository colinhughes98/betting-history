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
    [Authorize]
    [RoutePrefix("api/v1/bet")]
    public class BetController : BaseController
    {
        public BetController(IRepository repo):base(repo)
        {
        }        

        [HttpGet]
        [Route("", Name = "GetAllBets")]
        public async Task<IHttpActionResult> GetAllBetsAsync()
        {
            try
            {
                return Ok(await CreateGetAllBetsFactoryAsync());
            }
            catch (Exception)
            {
                return NotFound();
            }
        }       
    }    
}
