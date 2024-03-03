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
		// NIVEL LOCAL
		public Empleado(string nombre, string apellido,
			string cedula, string departamento,
			string cargo, string email, string telefono,
			string direccion, decimal sueldo, DateOnly fechaContratado)
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
		// obtenido de la DB
		public Empleado(int id, string nombre, string apellido, string cedula,
			string departamento, string cargo, string email,
			string telefono, string direccion, decimal sueldo, DateOnly fechaContratado)
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
		public string Direccion { get; set; }
		public decimal Sueldo { get; set; }
		public DateOnly FechaContratado { get; set; }

	}
}
