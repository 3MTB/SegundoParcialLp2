using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoParcialLp2.Data.DataLocal;
using SegundoParcialLp2.Models;

namespace SegundoParcialLp2.Data.Gestor
{
	public class gestorCxc
	{
		public static void InsertaCxc(CxC cxc)
		{
			try
			{
				var conex = new AmbarDataBase().GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = "insert into CxC([IdEmpleado],[TotalCxC],[FechaPrestamo]) values(@IdEmpleado,@TotalCxC,@FechaPrestamo)";
						if (conex.State != System.Data.ConnectionState.Open)
						{
							conex.Close();
							conex.Open();
						}
						SqlCommand cmd = new SqlCommand(query, conex);
						cmd.Parameters.AddWithValue("IdEmpleado", cxc.IdEmpleado);
						cmd.Parameters.AddWithValue("TotalCxC", cxc.TotalCxC);
						cmd.Parameters.AddWithValue("FechaPrestamo", cxc.FechaPrestamo.ToString());
						cmd.ExecuteNonQuery();
						conex.Close();
						MessageBox.Show("Add - CxC - Success", "Success");
						DatosLocales.ActualizaRegistroCxc();
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Error al insertar al CxC::\n{e.ToString()}");
			}

		}

		public static List<CxC> GetCxcs()
		{
			DatosLocales.ActualizaRegistroCxc();
			return DatosLocales.cxcs;
		}

	}
}
