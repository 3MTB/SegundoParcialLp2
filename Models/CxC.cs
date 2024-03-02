using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLp2.Models
{
    public class CxC
    {
        public CxC(int plazo, decimal cuotaDescontar, decimal totalCxC, DateTime fechaPrestamo)
        {
            Plazo = plazo;
            CuotaDescontar = cuotaDescontar;
            TotalCxC = totalCxC;
            FechaPrestamo = fechaPrestamo;
        }

        public CxC(int iD, int plazo, decimal cuotaDescontar, decimal totalCxC, DateTime fechaPrestamo)
        {
            ID = iD;
            Plazo = plazo;
            CuotaDescontar = cuotaDescontar;
            TotalCxC = totalCxC;
            FechaPrestamo = fechaPrestamo;
        }

        public int ID { get; set; }
        public int Plazo { get; set; }
        public decimal CuotaDescontar { get; set; }
        public decimal TotalCxC { get; set; }
        public DateTime FechaPrestamo { get; set; }
    }
}
