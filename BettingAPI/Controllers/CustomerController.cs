using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BettingAPI.Controllers
{
    [RoutePrefix("api/v1/customer")]
    public class CustomerController : ApiController
    {            
        [HttpGet]        
        [Route("{id}")]
        public IHttpActionResult GetCustomerDetails(int id)
        {
            var test = new {id};
            return Ok(test);
        }

        [HttpGet]
        [Route("{id}/order/{orderId}")]
        public IHttpActionResult GetCustomerOrderDetails(int id, int orderId)
        {
            var test = new {id, orderId};
            return Ok(test);
        }
    }
}
