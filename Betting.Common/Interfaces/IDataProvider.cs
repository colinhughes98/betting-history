using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Betting.Common.Models;

namespace Betting.Common.Interfaces
{
    public interface IDataProvider
    {
        IDataReader GetAllBetsHistory();
        IDataReader GetAllFixtures();
        IDataReader GetFixture(int id);
        IDataReader AddFixture(AddFixtureModel model);
        IDataReader DataAccressExecuteReader(string procName, IList<DbParameter> parameters = null);
    }
}
