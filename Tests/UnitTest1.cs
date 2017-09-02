using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Betting.Common.Handlers;
using Betting.Common.Interfaces;
using Betting.Common.Models;
using BettingAPI.Controllers;
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
            var repo = new Mock<IFixturesSerivce>();

            IEnumerable<FixtureDetailsModel> fdm = new[] {new FixtureDetailsModel {Description = "test", ID = 1}};

            repo.Setup(a => a.GetTheFixtures())
                .Returns(() => fdm);

            FixturesHandler fh = new FixturesHandler(repo.Object);
       
            var resp = fh.GetTheFixtures();

            repo.Verify();
            Assert.AreEqual(resp, fdm);
        }
    }
}
