using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLp2.Models
{
	public class CxC
	{
		public CxC(int iD, int idEmpleado, decimal totalCxC, DateOnly fechaPrestamo)
		{
			ID = iD;
			IdEmpleado = idEmpleado;
			TotalCxC = totalCxC;
			FechaPrestamo = fechaPrestamo;
		}
		public CxC(int idEmpleado, decimal totalCxC, DateOnly fechaPrestamo)
		{
			IdEmpleado = idEmpleado;
			TotalCxC = totalCxC;
			FechaPrestamo = fechaPrestamo;
		}

		public int ID { get; set; }
		public int IdEmpleado { get; set; }
		public decimal TotalCxC { get; set; }
		public DateOnly FechaPrestamo { get; set; }
	}
}
