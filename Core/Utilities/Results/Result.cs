using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	public class Result : IResult
	{
		//this demek classın kendini kastediyor.Burada result sınıfı oluyor.
		//this(success) : Result ın tek paremetreli constructorına success i yolluyoruz.
		//Böylece hem mesaj hem de sonuç döndürmek istediğimizde tekrardan success i set etmek yerine this ile iki constructorıda çalıştırabilmiş oluyoruz.
		public Result(bool success, string message) : this(success)
		{
			Message = message;
		}
		public Result(bool success)
		{
			Success = success;
		}
		public bool Success { get; }

		public string Message { get; }
	}
}
