using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DataProviderMock : IDataProvider
    {        
        public Task<bool> UpdateAsync()
        {
            return new Task<bool>(()=> true);
        }

        public async Task<DataSet> GeBetsFromDBAsync(int id)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            var row = dt.NewRow();
            dt.Columns.Add("Id");
            row["Id"] = 12;
            //var col = dt.Columns.Add("Id");                       
            dt.Rows.Add(row);
            ds.Tables.Add(dt);
            
            return  ds;
        }
    }
}
