using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {



            CarMenager carMenager = new CarMenager(new EfCarDal());
            EfCarDal efCarDal = new EfCarDal();

            foreach (var car in carMenager.GetAll())
            {
                Console.WriteLine(
                    "Araba Açıklaması : "+car.Description + 
                    "\nAraba Fiyatı     : "+car.DailyPrice+
                    "\n---------------------------------------");
            }
            Car car1 = new Car {Id=4,ColorId=3,BrandId=4,DailyPrice=0,ModelYear="2222",Description="a"};
            // efCarDal.Update(car1);
            Console.ReadLine();
        }
    }
}
