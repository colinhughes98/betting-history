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
        public void TestGetAllBets()
        {
            var betMock = new Mock<IBetHandler>();
            var repoMock = new Mock<IRepository>();

            //repoMock.Setup(a=>a.GetTheBets()).Returns(new BettingDetailsModel() {FirstName = })
            betMock.Setup(a => a.GetBets()).Returns(new BettingDetailsModel() {FirstName = "Col", Surname = "Hughes"});
            repoMock.Setup(a => a.GetTheBets())
                .Returns(new BettingDetailsModel() {FirstName = "colin", Surname = "Hughes"});

            BetController bc = new BetController(betMock.Object);
            bc.GetAllBets();

            betMock.VerifyAll();

            BetHandler bh = new BetHandler(repoMock.Object);
            var resp = bh.GetBets();

            repoMock.VerifyAll();

        }
    }
}
