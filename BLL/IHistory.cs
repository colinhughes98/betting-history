﻿using System.Threading.Tasks;

namespace BLL
{
    public interface IHistory
    {
        Task<dynamic> GetAllBetsAsync();
        //Task<FixtureDetails> GetBetAsync(int id);
        //Task<bool> AddBetAsync();
    }
}
