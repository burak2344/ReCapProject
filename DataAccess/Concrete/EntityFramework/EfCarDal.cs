using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDatabaseContext>, ICarDal
	{
		public List<CarDetailsDto> GetCarDetails()
		{
			using (ReCapProjectDatabaseContext context= new ReCapProjectDatabaseContext())
			{
				var result = from car in context.Cars
							 join brand in context.Brands
							 on car.BrandId equals brand.BrandId
							 join color in context.Colors
							 on car.ColorId equals color.ColorId
							 select new CarDetailsDto
							 {
								 CarId = car.CarId,
								 CarName=car.CarName,
								 BrandId = car.BrandId,
								 ColorId = car.ColorId,
								 BrandName=brand.BrandName,
								 Description = car.Description,
								 ColorName = color.ColorName,
								 ModelYear = car.ModelYear,
								 DailyPrice = car.DailyPrice,

							 };

				return result.ToList();
			}
		}
	}
}
