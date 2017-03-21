using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Betting.Common.Models;

namespace BettingAPI.Models
{
    public class GetTheBetsModel
    {
        public BettingDetailsModel Bets { get; set; }
        public string URL { get; set; }
    }
}