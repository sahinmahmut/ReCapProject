using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarMenager : ICarService
    {
        ICarDal _carDal;
        public CarMenager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetCarsByBrandId()
        {
            return _carDal.GetCarsByBrandId();
        }
        public List<Car> GetCarsByColorId()
        {
            return _carDal.GetCarsByColorId();
        }
    }
}
