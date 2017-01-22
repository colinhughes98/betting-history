using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using BLL;

namespace BettingAPI.Controllers
{    
    [RoutePrefix("api/v1/bet")]
    public class BetController : ApiController
    {
        [HttpGet]        
        [Route("")]
        public async Task<IHttpActionResult> GetAllBets()
        {            
            var test = new {Col = "Hi colin"};
            BLL.BettingHistory bh = new BettingHistory();
            await bh.AddBet();                      
            return Ok(test);
        }
       

        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetBet(int id)
        {
            BLL.BettingHistory bh = new BettingHistory();
            var x = await bh.GetBet(id);            
            return Ok(x);
        }
    }
}
