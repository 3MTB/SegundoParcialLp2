using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Cursor;

namespace SegundoParcialLp2.Models
{
	public class Gasto
	{
		public Gasto(int numeroCaja, string conceptoGasto,
			decimal totalGasto, string autorizadoPor,
			string recibidoPor, DateOnly fecha)
		{
			NumeroCaja = numeroCaja;
			ConceptoGasto = conceptoGasto;
			TotalGasto = totalGasto;
			AutorizadoPor = autorizadoPor;
			RecibidoPor = recibidoPor;
			Fecha = fecha;

		}

		public Gasto(int iD, int numeroCaja,
			string conceptoGasto, decimal totalGasto,
			string autorizadoPor, string recibidoPor, DateOnly fecha)
		{
			ID = iD;
			NumeroCaja = numeroCaja;
			ConceptoGasto = conceptoGasto;
			TotalGasto = totalGasto;
			AutorizadoPor = autorizadoPor;
			RecibidoPor = recibidoPor;
			Fecha = fecha;

		}

		public int ID { get; set; }
		public int NumeroCaja { get; set; }
		public string ConceptoGasto { get; set; }
		public decimal TotalGasto { get; set; }
		public string AutorizadoPor { get; set; }
		public string RecibidoPor { get; set; }
		public DateOnly Fecha { get; set; }
	}
}
