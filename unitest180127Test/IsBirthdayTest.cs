using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using unitest180127;

namespace unitest180127Test
{
    [TestClass]
    public class IsBirthdayTest
    {
        [TestMethod]
        public void TodayIs91Birthday()
        {
            var target = new FakeIsBirthday();
            target.SetToday(new DateTime(1999, 11, 28));

            Assert.AreEqual("Happy Birthday", target.Is91Birthday());
        }

        [TestMethod]
        public void TodayIsNo91Birthday()
        {
            var target = new FakeIsBirthday();
            target.SetToday(new DateTime(1999, 12, 2));

            Assert.AreEqual("No, Sorry", target.Is91Birthday());
        }

        //TODO: 可以用moke API
        public class FakeIsBirthday : IsBirthday
        {
            private DateTime _today;

            public void SetToday(DateTime date)
            {
                _today = date;
            }

            protected override DateTime GetToday()
            {
                return _today;
            }
        }
    }
}