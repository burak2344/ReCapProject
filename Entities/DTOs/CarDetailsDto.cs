using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
	public class CarDetailsDto:IDto
	{
		public int CarId { get; set; }
		public int BrandId { get; set; }
		public int ColorId { get; set; }
		public string CarName { get; set; }
		public string BrandName { get; set; }
		public string ColorName { get; set; }
		public decimal DailyPrice { get; set; }
		public short ModelYear { get; set; }
		public string Description { get; set; }

	}
}
