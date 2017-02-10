﻿using System;
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
        private IHistory history;
        public BetController(IHistory history)
        {
            this.history = history;
        }
        [HttpGet]        
        [Route("")]
        public async Task<IHttpActionResult> GetAllBetsAsync()
        {            
            var test = new {Col = "Hi colin"};            
            await history.AddBetAsync();                      
            return Ok(test);
        }        
       
        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetBetAsync(int id)
        {            
            var x = await history.GetBetAsync(id);            
            return Ok(x);
        }
    }
}
