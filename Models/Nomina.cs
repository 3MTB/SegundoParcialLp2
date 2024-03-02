using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLp2.Models
{
    public class Nomina
    {
        public Nomina(string tipoNomina, int idEmpleado, decimal aFP, int idCxC, decimal sueldoNeto)
        {
            TipoNomina = tipoNomina;
            IdEmpleado = idEmpleado;
            AFP = aFP;
            IdCxC = idCxC;
            SueldoNeto = sueldoNeto;
        }

        public Nomina(int iD, string tipoNomina, int idEmpleado, decimal aFP, int idCxC, decimal sueldoNeto)
        {
            ID = iD;
            TipoNomina = tipoNomina;
            IdEmpleado = idEmpleado;
            AFP = aFP;
            IdCxC = idCxC;
            SueldoNeto = sueldoNeto;
        }

        public int ID { get; set; }
        public string TipoNomina { get; set; }
        public int IdEmpleado { get; set; }
        public decimal AFP { get; set; }
        public int IdCxC { get; set; }
        public decimal SueldoNeto { get; set; }
    }
}
