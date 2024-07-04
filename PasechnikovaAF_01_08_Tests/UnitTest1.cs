using Microsoft.VisualStudio.TestTools.UnitTesting;

using PasechnikovaAF_01_08.Classes;

namespace PasechnikovaAF_01_08_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//������ ������� Q
        {
            Car car = new Car(5, 0.1);
            var res = car.Q();//��������� �������
            Assert.AreEqual(50, res);//��������� ��������
        }
        [TestMethod]
        public void TestMethod2()//������ ������� Qp, ���� p < 5
        {
            CarYear carYear = new CarYear(5, 0.1, 3);
            var res = carYear.Qp();//��������� �������
            Assert.AreEqual(172.5, res);//�������� ��������
        }
        [TestMethod]
        public void TestMethod3()//������ ������� Qp, ���� p >= 5
        {
            CarYear carYear = new CarYear(5, 0.1, 6);
            var res = carYear.Qp();//��������� �������
            Assert.AreEqual(510, res);//�������� ��������
        }
        [TestMethod]
        public void TestMethod4()//������ ������� Qp, ���� ������ �� �� = 0
        {
            CarYear carYear = new CarYear(5, 0, 6);
            var res = carYear.Qp();//��������� �������
            Assert.AreEqual(-1, res);//�������� ��������
        }
        [TestMethod]
        public void TestMethod5()//������ ������� Q, ���� ������ �� �� = 0
        {
            Car car = new Car(5, 0);
            var res = car.Q();//��������� �������
            Assert.AreEqual(-1, res);//�������� ��������
        }
    }
}
