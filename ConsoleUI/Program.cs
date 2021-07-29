using Business.Concrete;
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
			//CarDailyPrice();
			//GetBrandName();
			//CarDetailDto();

		}

		private static void CarDetailDto()
		{
			CarManager carManager = new CarManager(new EfCarDal());

			foreach (var car in carManager.GetCarDetails())
			{
				Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
			}
		}

		private static void GetBrandName()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			foreach (var brand in brandManager.GetAll())
			{
				Console.WriteLine(brand.BrandName);
			}
		}

		private static void CarDailyPrice()
		{
			CarManager carManager = new CarManager(new EfCarDal());

			foreach (var car in carManager.GetByDailyPrice(0))
			{
				Console.WriteLine(car.CarName);
			}
		}
	}
}
