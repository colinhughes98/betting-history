using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Interfaces;
using Betting.Common.Models;

namespace BettingAPI.DomainLogic
{
    public class BaseController : ApiController
    {
        private ITheBets bets;
        public BaseController(ITheBets bets)
        {
            this.bets = bets;
        }

        public IHttpActionResult Create(string action)
        {            
            try
            {
                switch (action)
                {
                    case "GetAllBets":
                        //SomeBusinessLogicForBets some = new SomeBusinessLogicForBets(dataProvider);
                        UrlHelper url = new UrlHelper(Request);
                        return Ok(new {bets = bets.GetTheBets(), url = url.Link(action, null)});
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
