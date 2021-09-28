﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICarService
	{
		IResult Add(Car car);
		IResult Delete(Car car);
		IResult Update(Car car);
		IDataResult<List<Car>> GetAll();
		IDataResult<Car> GetById(int id);
		IDataResult<List<Car>> GetAllByBrand(int id);
		IDataResult<List<Car>> GetByDailyPrice(decimal max);
		IDataResult<List<CarDetailsDto>> GetCarDetails();
	}
}
