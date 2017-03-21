using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Enums;
using BettingAPI.Models;

namespace BettingAPI.DomainLogic
{    
    public class BaseController : ApiController
    {
        private ITheBets bets;
        public BaseController(ITheBets bets)
        {
            this.bets = bets;
        }

        //public IHttpActionResult ModelFactory(RouteEnum action)
        //{           
        //    try
        //    {
        //        switch (action)
        //        {                        
        //            case RouteEnum.CreateGetAllBets:                        
        //                UrlHelper url = new UrlHelper(Request);
        //                return Ok(new
        //                {
        //                    bets = bets.GetTheBets(), 
        //                    url = url.Link(Enum.GetName(typeof(RouteEnum), action), null)
        //                });
        //            default:
        //                return NotFound();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return InternalServerError();
        //    }                        
        //}

        protected GetTheBetsModel CreateGetAllBets()
        {
            UrlHelper url = new UrlHelper(Request);
            return new GetTheBetsModel
            {
                Bets = bets.GetTheBets(),
                URL = url.Link("", null)
            };
        }
    }    
}
