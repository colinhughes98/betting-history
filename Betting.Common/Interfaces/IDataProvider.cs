using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Betting.Common.Interfaces
{
    public interface IDataProvider
    {
        IDataReader GetAllBetsHistory();
        IDataReader GetAllFixtures();
    }
}
