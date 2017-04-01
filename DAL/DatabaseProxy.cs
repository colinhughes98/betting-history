using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting.Common;
using Betting.Common.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Configuration;

namespace DAL
{
    public class DatabaseProxy : IDataProvider
    {                   
        public IDataReader GetAllBetsHistory()
        {
           var connString =  ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
          
            Database db = new SqlDatabase(connString);
           
            using (var connection = db.CreateConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "dbo.GetListOfFixtures";
                command.CommandType = CommandType.StoredProcedure;

                return command.ExecuteReader();                          
            }
        }
    }
}
