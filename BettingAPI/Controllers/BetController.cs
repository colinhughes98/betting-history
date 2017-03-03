using System;
using System.Web.Http;
using Betting.Common;
using Betting.Common.Interfaces;
using Betting.Common.Models;

namespace BettingAPI.Controllers
{
    [RoutePrefix("api/v1/bet")]
    public class BetController : ApiController
    {
        private IHistory history;

        public BetController(IHistory history)
        {
            this.history = history;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllBetsAsync()
        {
            BettingDetailsModel details;
            try
            {
                details = history.GetAllBets();
                if (details == null) return InternalServerError();
            }
            catch (Exception)
            {
                return InternalServerError();               
            }
           
            return Ok(details);
        }       
    }
}
