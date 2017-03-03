using System;
using System.Threading.Tasks;
using BettingAPI.Controllers;
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
