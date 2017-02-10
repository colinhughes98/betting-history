using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DatabaseProxy : IDataProvider<DataSet>
    {
        public Task<bool> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DataSet> GetDataFromDBAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
