﻿using System;
using System.Net.Http;
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
    public class BetController : BaseController
    {
        public BetController(ITheBets bets):base(bets)
        {
        }        

        [HttpGet]
        [Route("", Name = "GetAllBets")]
        public IHttpActionResult GetAllBetsAsync()
        {            
           return Create(RouteEnum.GetAllBets);                            
        }       
    }    
}
