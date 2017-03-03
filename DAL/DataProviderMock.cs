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
    public class DataProviderMock : IDataProvider
    {        
        //public Task<bool> UpdateAsync()
        //{
        //    return new Task<bool>(()=> true);
        //}

        //public async Task<DataSet> GeBetsFromDBAsync(int id)
        //{
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    var row = dt.NewRow();
        //    dt.Columns.Add("Id");
        //    row["Id"] = 12;            
        //    dt.Rows.Add(row);
        //    ds.Tables.Add(dt);            
        //    return  ds;
        //}


        public Task<IEnumerable> GetAllBetsHistoryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
