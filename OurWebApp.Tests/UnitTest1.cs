namespace OurWebApp.Dates.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyDatesSince()
        {
            Assert.AreEqual(38795, DateManager.DaysSince(DateManager.TitanicSank, DateTime.Parse("07/03/2018")));
            Assert.AreEqual(88387, DateManager.DaysSince(DateManager.AmericanIndependenceDay, DateTime.Parse("07/03/2018")));
            Assert.AreEqual(347608, DateManager.DaysSince(DateManager.BattleOfHastings, DateTime.Parse("07/03/2018")));
        }
    }
}
