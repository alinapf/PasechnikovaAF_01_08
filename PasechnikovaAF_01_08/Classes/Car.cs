using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasechnikovaAF_01_08.Classes
{
    public class Car//базовый класс
    {
        public double mileage { get; set; }
        public double consumption { get; set; }
        public Car(double _mileage, double _consumption) //Конструктор класса
        {
            mileage = _mileage;
            consumption = _consumption;
        }
        public double Q()//Функция, которая определяет качество объекта – Q по заданной формуле
        {
            if (consumption != 0) return Math.Round(mileage / consumption, 2);
            else return -1;
        }
        public virtual string Info()//Вывод информации об объекте
        {
            return $"\nПробег: {mileage}, расход на км: {consumption}, Q(Качество объекта): {Q()}";
        }
    }
}
