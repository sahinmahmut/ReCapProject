using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> { 
            new Car {Id=1,ColorId=2,BrandId=3,DailyPrice=25000,Description="Ford Marka Araba",ModelYear="2012"},
            new Car {Id=2,ColorId=1,BrandId=1,DailyPrice=250000,Description="Volvo Marka Araba",ModelYear="2001"},
            new Car {Id=3,ColorId=1,BrandId=3,DailyPrice=2500,Description="Tofaş Marka Araba",ModelYear="2021"},
            new Car {Id=4,ColorId=3,BrandId=2,DailyPrice=52000,Description="Renault Marka Araba",ModelYear="2019"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c=>c.Id==car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}
