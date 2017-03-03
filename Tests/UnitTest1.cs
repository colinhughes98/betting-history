using System;
using System.Linq;
using System.Threading.Tasks;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Controllers;
using BettingAPI.DomainLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var results = new[] { "ColinTest", "HughesTest" };
            BettingDetailsModel bmodel = new BettingDetailsModel();
            bmodel.FirstName = results.FirstOrDefault();
            bmodel.Surname = results.LastOrDefault();
            
            var dataProvider = new Mock<IDataProvider>();
            dataProvider.Setup(x => x.GetAllBetsHistory()).Returns(results);

            var history = new Mock<IHistory>();
            history.Setup(x => x.GetAllBets()).Returns(bmodel);

            
            //Act
            BettingHistory hist = new BettingHistory(dataProvider.Object);
            hist.GetAllBets();
            BetController bc = new BetController(history.Object);
            var result = bc.GetAllBetsAsync();

            //Assert
            dataProvider.Verify(a => a.GetAllBetsHistory(), Times.Once());
            //history.Verify(a => a.GetAllBets(), Times.Once);

            //Task<bool> response = new Task<bool>( ()=> true);
            //var dataMoq = new Mock<IDataProvider>();
            //var bh = new BettingHistory(dataMoq.Object);
            //dataMoq.Setup(x => x.UpdateAsync()).Returns(response);
            ////Act           
            //var y = bh.AddBetAsync();
            ////Assert
            //Assert.AreEqual(response.Result, y.Result);
        }
    }
}
