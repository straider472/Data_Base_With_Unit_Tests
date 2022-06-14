using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        //Тест с положительным сценарием
        [TestMethod()]
        public void Is_PresentTest_Good()
        {
            //Входные данные
            string login = "admin";
            string password = "123";
            //Ожидаемый результат
            bool expected = true;
            //Фактический результат
            bool actual = Class1.Is_Present(login, password);
            //Сравнение ожидаемого и фактического результата
            Assert.AreEqual(expected, actual);
        }

        //Тест с отрицательным сценарием
        [TestMethod()]
        public void Is_PresentTest_Bad()
        {
            //Входные данные
            string login = "admin";
            string password = "12";
            //Ожидаемый результат
            bool expected = false;
            //Фактический результат
            bool actual = Class1.Is_Present(login, password);
            //Сравнение ожидаемого и фактического результата
            Assert.AreEqual(expected, actual);
        }
    }
}