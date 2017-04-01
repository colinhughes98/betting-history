﻿using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Models;

namespace BettingAPI.DomainLogic
{    
    public abstract class BaseApiController : ApiController
    {
        private ModelFactory _modelFactory;

        protected BaseApiController(IRepository repo)
        {            
            TheRepository = repo;            
        }

        protected ModelFactory TheModelFactory => _modelFactory ?? (_modelFactory = new ModelFactory(Request));

        protected IRepository TheRepository { get; }
    }

    public class ModelFactory
    {
        private readonly HttpRequestMessage _request;
        private readonly UrlHelper _url;

        public ModelFactory(HttpRequestMessage request)
        {
            _request = request;
            _url = new UrlHelper(_request);
        }

        public GetTheBetsModel Create(BettingDetailsModel bets)
        {
            return new GetTheBetsModel
            {
                Bets = bets,
                URL = _url.Link("GetAllBets", null)
            };
        }
    }
}
