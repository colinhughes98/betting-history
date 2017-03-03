using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using BettingAPI.Interfaces;


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
            var x = history.GetAllBets();
            if (x == null) return InternalServerError();

            return Ok(x);
        }        
       
        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IHttpActionResult> GetBetAsync(int id)
        //{            
        //    var x = await history.GetBetAsync(id);            
        //    return Ok(x);
        //}
    }
}
