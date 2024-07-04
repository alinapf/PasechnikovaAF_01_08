using PasechnikovaAF_01_08.Classes;

using System;

namespace PasechnikovaAF_01_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double mileage, consumption, p;
            Console.Write("Введите пробег машины: ");
            mileage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расход на км машины: ");
            consumption = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(mileage, consumption);//Создание объекта базового класса
            Console.WriteLine(car.Info() +"\n");

            Console.Write("Введите год выпуска машины: ");
            p = Convert.ToDouble(Console.ReadLine());
            CarYear carYear = new CarYear(mileage, consumption, p);//Создание объекта класса потомка
            Console.WriteLine(carYear.Info());
        }
    }
}
