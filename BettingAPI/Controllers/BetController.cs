using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Routing;
using Betting.Common;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.BaseController;
using BettingAPI.Enums;
using BettingAPI.Models;

namespace BettingAPI.Controllers
{        
    [RoutePrefix("api/v1/bet")]
    public class BetController : BaseApiController
    {
    //    private readonly IBetHandler _bet;

    //    public BetController(IBetHandler bet)
    //    {
    //        _bet = bet;
    //    }

    //    [HttpGet]
    //    [Route("", Name = "GetAllBets")]
    //    public IHttpActionResult GetAllBets()
    //    {
    //        try
    //        {
    //            var bets =_bet.GetBets();
    //            var getAll = TheModelFactory.Create(bets);
    //            return Ok(getAll);
    //        }
    //        catch (Exception ex)
    //        {
    //            return BadRequest(ex.Message);
    //        }
    //    }       
    //}

    //public class BetHandler : IBetHandler
    //{
    //    private readonly IFixturesSerivce _repo;

    //    public BetHandler(IFixturesSerivce repo)
    //    {
    //        _repo = repo;
    //    }
    //    public BettingDetailsModel GetBets()
    //    {
    //       return _repo.GetTheBets();
    //    }
    //}

    //public interface IBetHandler
    //{
    //    BettingDetailsModel GetBets();
    }
}
