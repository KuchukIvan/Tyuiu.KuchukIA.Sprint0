﻿using Tyuiu.KuchukIA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KuchukIA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Иван";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Иван", res);
        }
      
    }
}
