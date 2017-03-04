using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Enums;

namespace BettingAPI.DomainLogic
{    
    public class BaseController : ApiController
    {
        private ITheBets bets;
        public BaseController(ITheBets bets)
        {
            this.bets = bets;
        }

        public IHttpActionResult Create(RouteEnum action)
        {            
            try
            {
                switch (action)
                {
                    case RouteEnum.GetAllBets:                        
                        UrlHelper url = new UrlHelper(Request);
                        return Ok(new {bets = bets.GetTheBets(), url = url.Link(Enum.GetName(typeof(RouteEnum), action), null)});
                    default:
                        return NotFound();
                }
            }
            catch (Exception)
            {
                return InternalServerError();
            }                        
        }
    } 
}
