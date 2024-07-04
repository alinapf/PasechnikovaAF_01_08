using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasechnikovaAF_01_08.Classes
{
    public class CarYear : Car//класс потомок с указанием базового класса
    {
        public double p { get; set; }
        public CarYear(double _mileage, double _consumption, double _p) : base(_mileage, _consumption)
        {
            p = _p;
        }
        public double Qp()//Функция Qp, которая определяет «качество» объекта класса потомка
        {
            if (base.Q() != -1)
            {
                if (p < 5) return Math.Round(base.Q() * 1.15 * p, 2);
                else return Math.Round(base.Q() * 1.7 * p, 2);
            }
            else return -1;
        }
        public override string Info()//Вывод информации об объекте с дополнительными данными
        {
            return base.Info()+$", Год выпуска: {p}, Qp: {Qp()}";
        }
    }
}
