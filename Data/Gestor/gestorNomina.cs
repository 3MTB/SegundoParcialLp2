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
	public class gestorNomina
	{
		public static void InsertNomina(Nomina nomina, bool isFranly)
		{
			try
			{
				var conex = new AmbarDataBase(isFranly).GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = "EXECUTE GeneraRegistroNomina @IdEmpleado,@IdCxc,@TipoNomina,@SeguroSocial,@AFP;";
						SqlCommand cmd = new SqlCommand(query, conex);
						cmd.Parameters.AddWithValue("IdEmpleado", nomina.IdEmpleado);
						cmd.Parameters.AddWithValue("IdCxc", nomina.IdCxC);
						cmd.Parameters.AddWithValue("TipoNomina", nomina.TipoNomina);
						cmd.Parameters.AddWithValue("SeguroSocial", nomina.SeguroSocial);
						cmd.Parameters.AddWithValue("AFP", nomina.AFP);
						cmd.ExecuteNonQuery();
						DatosLocales.ActualizaRegistroNomina(isFranly);
						MessageBox.Show("Nomina cargada");
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo fallo al momento de insertar la nomina:::\n{e.Message}");
			}
		}
		public static List<Nomina> GetNominas(bool IsFranly)
		{
			DatosLocales.ActualizaRegistroNomina(IsFranly);
			return DatosLocales.nominas;
		}
	}
}
