using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Interfaces;
using Betting.Common.Models;

namespace BettingAPI.DomainLogic
{
    public class BaseController : ApiController, IModelFactory<IHttpActionResult>
    {
        private readonly IDataProvider dataProvider;

        public BaseController(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public IHttpActionResult Create(string action)
        {
            //switch/case statements to create model
            //first one will be 
            var hist = dataProvider.GetAllBetsHistory();
            if (hist == null) return NotFound();

            UrlHelper url = new UrlHelper(Request);            
            BettingDetailsModel bd = new BettingDetailsModel { FirstName = hist.FirstOrDefault(), Surname = hist.LastOrDefault(), URL = url.Link(action, null)};
            return Ok(bd);
        }
    }       
}
