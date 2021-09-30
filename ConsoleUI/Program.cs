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
			UserTest();

		}

		private static void CarDetailDto()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetCarDetails();
			if (result.Success)
			{
				foreach (var car in result.Data)
				{
					Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
				}
				Console.WriteLine(result.Message);
			}
			else
			{
				Console.WriteLine(result.Message);
			}
		}

		private static void GetBrandName()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			var result = brandManager.GetAll();
			if (result.Success)
			{
				foreach (var brand in result.Data)
				{
					Console.WriteLine(brand.BrandName);
				}
				Console.WriteLine(result.Message);
			}
			else
			{
				Console.WriteLine(result.Message);
			}
		}

		private static void CarDailyPrice()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetByDailyPrice(0);
			if (result.Success)
			{
				foreach (var car in result.Data)
				{
					Console.WriteLine(car.CarName);
				}
				Console.WriteLine(result.Message);
			}
			else
			{
				Console.WriteLine(result.Message);
			}
		}

		private static void UserTest()
		{
			UserManager userManager = new UserManager(new EfUserDal());
			var result2 = userManager.Add(new User { FirstName = "Ad", LastName = "Soyad", Email = "ad-soyad@hotmail.com", Password = "1" });
			Console.WriteLine(result2.Message);
			var result = userManager.GetAll();
			if (result.Success)
			{
				foreach (var user in result.Data)
				{
					Console.WriteLine(user.FirstName + " " + user.LastName + " " + user.Email + " " + user.Password);

				}
				Console.WriteLine(result.Message);
			}
			else
			{
				Console.WriteLine(result.Message);
			}
		}	

	}
}
