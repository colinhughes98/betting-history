using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common;


namespace DAL
{
    public class DatabaseProxy : IDataProvider
    {
        //public Task<bool> UpdateAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<DataSet> GeBetsFromDBAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}


        public IEnumerable<string> GetAllBetsHistory()
        {
            var results = new[] { "Colin", "Hughes" };
            return results;
        }
    }
}
