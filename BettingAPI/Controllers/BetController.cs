using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common;
using BettingAPI.ModelFactories;


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
            BettingDetails details;
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
