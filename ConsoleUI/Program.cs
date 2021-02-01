using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarMenager carMenager = new CarMenager(new InMemoryCarDal());
            foreach (var car in carMenager.GetAll())
            {
                Console.WriteLine("Araba Açıklaması : "+car.Description + "\nAraba Fiyatı     : "+car.DailyPrice+"\n---------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
