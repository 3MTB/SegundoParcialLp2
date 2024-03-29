﻿using System;
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
		public static void InsertNomina(Nomina nomina)
		{
			try
			{
				var conex = new AmbarDataBase().GetConection();
				if (conex != null)
				{
					using (conex)
					{
						string query = $"EXEC GeneraRegistroNomina {nomina.IdCxC},{nomina.IdEmpleado},{nomina.TipoNomina},{nomina.SeguroSocial},{nomina.AFP};";
						SqlCommand cmd = new SqlCommand(query, conex);
						cmd.ExecuteNonQuery();
						conex.Close();
						MessageBox.Show("Success add nomina", "Success");
						DatosLocales.ActualizaRegistroNomina();
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"Algo fallo al momento de insertar la nomina:::\n{e.ToString()}");
			}
		}
		public static List<Nomina> GetNominas()
		{
			DatosLocales.ActualizaRegistroNomina();

			return DatosLocales.nominas;
		}
	}
}
