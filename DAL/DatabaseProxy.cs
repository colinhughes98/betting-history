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
        readonly string connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public IDataReader GetAllBetsHistory()
        {
            return DataAccressExecuteReader("dbo.GetListOfFixtures");
        }

        private IDataReader DataAccressExecuteReader(string procName)
        {
            Database db = new SqlDatabase(connString);
            IDataReader dr;

            var connection = db.CreateConnection();

            //using (var connection = db.CreateConnection())
            //{
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = procName;
                command.CommandType = CommandType.StoredProcedure;

                dr = command.ExecuteReader();
            //}

            return dr;
        }

        public IDataReader GetAllFixtures()
        {
            return DataAccressExecuteReader("dbo.GetListOfFixtures");
        }
    }
}
