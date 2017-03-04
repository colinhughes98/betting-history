﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common.Models;

namespace Betting.Common.Interfaces
{
    public interface ITheBets
    {
        BettingDetailsModel GetTheBets();

        BettingDetailsModel GetTheBets(int id);
    }
}
