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
	public class gestorGasto
	{
		public static void InsertaGasto(Gasto gasto)
		{
			try
			{
				var conex = new AmbarDataBase().GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = "insert into Gasto([NumeroCaja],[ConceptoGasto],[TotalGasto],[QuienAutoriza],[QuienRecibe],[Fecha]) values(@numeroCaja, @conceptoGasto,@totalGasto,@quienAutoriza,@quienRecibe,@fecha)";
						if (conex.State != System.Data.ConnectionState.Open)
						{
							conex.Close();
							conex.Open();
						}
						SqlCommand cmd = new SqlCommand(query, conex);
						cmd.Parameters.AddWithValue("numeroCaja", gasto.NumeroCaja);
						cmd.Parameters.AddWithValue("conceptoGasto", gasto.ConceptoGasto);
						cmd.Parameters.AddWithValue("totalGasto", gasto.TotalGasto);
						cmd.Parameters.AddWithValue("quienAutoriza", gasto.AutorizadoPor);
						cmd.Parameters.AddWithValue("quienRecibe", gasto.RecibidoPor);
						cmd.Parameters.AddWithValue("fecha", gasto.Fecha.ToString());
						cmd.ExecuteNonQuery();
						conex.Close();
						MessageBox.Show("Add - Gasto");
						DatosLocales.ActualizaRegistroGasto();
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Error al insertar al GASTO::\n{e.ToString()}");
			}

		}

		public static List<Gasto> getGastos()
		{
			DatosLocales.ActualizaRegistroGasto();
			return DatosLocales.gastos;
		}
	}
}
