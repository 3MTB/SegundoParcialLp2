using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialLp2.Models
{
    public class Empleado
    {
        public Empleado(string nombre, string apellido,
            string cedula, string departamento,
            string cargo, string email, string telefono,
            string direccion, decimal sueldo, string fechaContratado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Departamento = departamento;
            Cargo = cargo;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
            Sueldo = sueldo;
            FechaContratado = fechaContratado;
        }

        public Empleado(int id, string nombre, string apellido, string cedula,
            string departamento, string cargo, string email,
            string telefono, string direccion, decimal sueldo, string fechaContratado)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Departamento = departamento;
            Cargo = cargo;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
            Sueldo = sueldo;
            FechaContratado = fechaContratado;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion {  get; set; }
        public decimal Sueldo { get; set; }
        public string FechaContratado { get; set; }

    }
}
