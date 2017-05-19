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
using System.Data.Common;
using System.Data.SqlClient;
using Betting.Common.Models;

namespace DAL
{
    public class DatabaseProxy : IDataProvider
    {
        static readonly string connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public IDataReader GetAllBetsHistory()
        {
            return DataAccressExecuteReader("dbo.GetListOfFixtures");
        }

        public IDataReader DataAccressExecuteReader(string procName, IList<DbParameter> parameters = null)
        {
            Database db = new SqlDatabase(connString);

            var connection = db.CreateConnection();
            
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null) command.Parameters.AddRange(parameters.ToArray());

            IDataReader dr = command.ExecuteReader();

            return dr;
        }

        public IDataReader GetAllFixtures()
        {
            return DataAccressExecuteReader("BettingHistory.dbo.GetListOfFixtures");
        }

        public IDataReader GetFixture(int id)
        {
            IList<DbParameter> parameters = new List<DbParameter>();
            parameters.Add(new SqlParameter() {ParameterName = "id", DbType = DbType.Int32, Value = id});
            return DataAccressExecuteReader("BettingHistory.dbo.GetListOfFixtures", parameters);
        }

        public IDataReader AddFixture(AddFixtureModel model)
        {
            IList<DbParameter> parameters = new List<DbParameter>();
            parameters.Add(new SqlParameter() { ParameterName = "description", DbType = DbType.String, Value = model.Description });
            return DataAccressExecuteReader("BettingHistory.dbo.AddFixture", parameters);
        }

       
    }
}
