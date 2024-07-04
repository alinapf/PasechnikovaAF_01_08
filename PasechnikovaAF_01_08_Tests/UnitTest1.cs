using Microsoft.VisualStudio.TestTools.UnitTesting;

using PasechnikovaAF_01_08.Classes;

namespace PasechnikovaAF_01_08_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//работа функции Q
        {
            Car car = new Car(5, 0.1);
            var res = car.Q();//результат функции
            Assert.AreEqual(50, res);//прооверка значений
        }
        [TestMethod]
        public void TestMethod2()//работа функции Qp, если p < 5
        {
            CarYear carYear = new CarYear(5, 0.1, 3);
            var res = carYear.Qp();//результат функции
            Assert.AreEqual(172.5, res);//проверка значений
        }
        [TestMethod]
        public void TestMethod3()//работа функции Qp, если p >= 5
        {
            CarYear carYear = new CarYear(5, 0.1, 6);
            var res = carYear.Qp();//результат функции
            Assert.AreEqual(510, res);//проверка значений
        }
        [TestMethod]
        public void TestMethod4()//работа функции Qp, если расход на км = 0
        {
            CarYear carYear = new CarYear(5, 0, 6);
            var res = carYear.Qp();//результат функции
            Assert.AreEqual(-1, res);//проверка значений
        }
        [TestMethod]
        public void TestMethod5()//работа функции Q, если расход на км = 0
        {
            Car car = new Car(5, 0);
            var res = car.Q();//результат функции
            Assert.AreEqual(-1, res);//проверка значений
        }
    }
}
