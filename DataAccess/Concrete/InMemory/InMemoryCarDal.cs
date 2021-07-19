using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;
		public InMemoryCarDal()
		{
			_cars = new List<Car> { 
			new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1968,DailyPrice=15000,Description="Hava yastıları açıldı."},
			new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=1980,DailyPrice=55000,Description="Bazı kısımları boyalı."},
			new Car{CarId=3,BrandId=1,ColorId=1,ModelYear=1973,DailyPrice=45000,Description="Lastikler ve bujiler değişti."},
			new Car{CarId=4,BrandId=2,ColorId=2,ModelYear=2010,DailyPrice=95000,Description="Koltuklar değişti."},
			new Car{CarId=5,BrandId=2,ColorId=3,ModelYear=2012,DailyPrice=105000,Description="Ön kapı arızalı."},
			new Car{CarId=6,BrandId=2,ColorId=2,ModelYear=2015,DailyPrice=150000,Description="Sıfır Araba."},
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
			_cars.Remove(carToDelete);
		}

		public Car Get(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetById(int carId)
		{
			return _cars.Where(c => c.CarId == carId).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.ModelYear = car.ModelYear;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;	
		}
	}
}
