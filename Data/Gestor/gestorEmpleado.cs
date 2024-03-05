using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.X509;
using SegundoParcialLp2.Models;
using SegundoParcialLp2.Data.DataLocal;
namespace SegundoParcialLp2.Data.Gestor
{
	public class gestorEmpleado
	{
		public static void InsertaEmpleado(Empleado employee, bool isFranly)
		{

			try
			{
				if (DatosLocales.empleados.Any(x => x == employee))
				{
					MessageBox.Show("Ya existe un empleado registrado con dichos datos");
					return;
				}
				var conex = new AmbarDataBase(isFranly).GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = $"insert into Empleado([Nombre],[Apellido],[Cedula],[Departamento],[Cargo],[Email],[Telefono],[Direccion],[Sueldo],[FechaContratado]) values(@nombre,@apellido,@cedula,@departamento,@cargo,@email,@telefono,@direccion,@sueldo,@fechaContratado)";
						if (conex.State != System.Data.ConnectionState.Open)
						{
							conex.Open();
						}
						SqlCommand cmd = new SqlCommand(query, conex);
						cmd.Parameters.AddWithValue("nombre", employee.Nombre);
						cmd.Parameters.AddWithValue("apellido", employee.Apellido);
						cmd.Parameters.AddWithValue("cedula", employee.Cedula);
						cmd.Parameters.AddWithValue("departamento", employee.Departamento);
						cmd.Parameters.AddWithValue("cargo", employee.Cargo);
						cmd.Parameters.AddWithValue("email", employee.Email);
						cmd.Parameters.AddWithValue("telefono", employee.Telefono);
						cmd.Parameters.AddWithValue("direccion", employee.Direccion);
						cmd.Parameters.AddWithValue("sueldo", employee.Sueldo);
						cmd.Parameters.AddWithValue("fechaContratado", employee.FechaContratado.ToString());
						cmd.ExecuteNonQuery();
						conex.Close();

						DatosLocales.ActualizaRegistroEmpleados(isFranly);
						MessageBox.Show("Empleado agregado", "Success");

					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Error al insertar al empleado::\n{e.Message}");
			}

		}

		public static List<Empleado> GetEmpleados(bool IsFranly)
		{
			DatosLocales.ActualizaRegistroEmpleados(IsFranly);

			return DatosLocales.empleados;
		}

	}
}
