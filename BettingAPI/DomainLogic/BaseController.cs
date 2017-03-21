using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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
        private readonly IRepository _repo;
        public BaseController(IRepository repo)
        {
            _repo = repo;
        }

        //public IHttpActionResult ModelFactory(RouteEnum action)
        //{           
        //    try
        //    {
        //        switch (action)
        //        {                        
        //            case RouteEnum.CreateGetAllBetsFactoryAsync:                        
        //                UrlHelper url = new UrlHelper(Request);
        //                return Ok(new
        //                {
        //                    repo = repo.GetTheBets(), 
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

        protected async Task<GetTheBetsModel> CreateGetAllBetsFactoryAsync()
        {
            UrlHelper url = new UrlHelper(Request);
            var bets = await _repo.GetTheBetsAsync();
            return new GetTheBetsModel
            {
                Bets = bets,
                URL = url.Link("GetAllBets", null)
            };
        }
    }    
}
