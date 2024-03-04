﻿using System.Data;
using System.Data.SqlClient;
using SegundoParcialLp2.Models;

namespace SegundoParcialLp2.Data.DataLocal
{
	public class DatosLocales
	{
		public static List<Empleado> empleados = new List<Empleado>();
		public static List<CxC> cxcs = new List<CxC>();

		public static void ActualizaRegistroEmpleados(bool isFranly)
		{
			try
			{
				var conex = new AmbarDataBase(isFranly).GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = "select * FROM Empleado";
						if (conex.State != ConnectionState.Open)
						{
							conex.Open();
						}
						SqlDataAdapter adapter = new SqlDataAdapter(query, conex);
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						empleados.Clear();
						foreach (DataRow x in dt.Rows)
						{
							int id = (int)x["Id"];
							var nombre = x["Nombre"].ToString();
							var apellido = x["Apellido"]!.ToString();
							var cedula = x["Cedula"].ToString();
							var departamento = x["Departamento"].ToString();
							var cargo = x["Cargo"].ToString();
							var email = x["Email"].ToString();
							var telefono = x["Telefono"].ToString();
							var direccion = x["Direccion"].ToString();
							var sueldo = (decimal)x["Sueldo"];
							var fechaContratado = DateOnly.FromDateTime((DateTime)x["FechaContratado"]);
							Empleado emp = new Empleado(id, nombre, apellido, cedula, departamento, cargo, email, telefono, direccion, sueldo, fechaContratado);
							empleados.Add(emp);
						}

					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Error al obtener los registros empleado::\n{e.Message}");
			}

		}
		public static void ActualizaRegistroCxc(bool isFranly)
		{
			try
			{
				var conex = new AmbarDataBase(isFranly).GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = "select * FROM CxC";
						if (conex.State != ConnectionState.Open)
						{
							conex.Open();
						}
						SqlDataAdapter adapter = new SqlDataAdapter(query, conex);
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						cxcs.Clear();
						foreach (DataRow x in dt.Rows)
						{
							int id = (int)x["Id"];
							int idEmpleado = (int)x["IdEmpleado"];
							var totalCxC = (decimal)x["TotalCxc"];
							var fechaPrestamos = DateOnly.FromDateTime((DateTime)x["FechaPrestamo"]);
							CxC cxc = new CxC(id, idEmpleado, totalCxC, fechaPrestamos);
							cxcs.Add(cxc);
						}


					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Error al obtener los registros de CXC::\n{e.Message}");
			}

		}

	}
}
