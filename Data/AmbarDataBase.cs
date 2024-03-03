using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SegundoParcialLp2.Data
{
	public class AmbarDataBase
	{

		// "Server=DRAKO\\SQLEXPRESS; Database=rentcargokudemon; Trusted_Connection=True;TrustServerCertificate=True")
		private static string conectionString { get; set; }
		private static SqlConnection conexGeneral = new SqlConnection();

		public AmbarDataBase(bool isFranly)
		{
			if (isFranly)
			{
				conectionString = "Server=DESKTOP-SQ41TDR\\SQLEXPRESS01; Database=Ambar; Trusted_Connection=True;TrustServerCertificate=True";
			}
			else
			{
				conectionString = "Server=DRAKO\\SQLEXPRESS; Database=Ambar; Trusted_Connection=True;TrustServerCertificate=True";
			}
			MessageBox.Show((isFranly ? "Franly" : "Eury"));

		}
		public SqlConnection? GetConection()
		{
			try
			{
				if (conexGeneral.State != ConnectionState.Closed)
				{
					conexGeneral.Close();
				}

				conexGeneral.ConnectionString = conectionString;
				conexGeneral.Open();

				return conexGeneral;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString(), "Error al conectarse a la DB.");
				return null;
			}
		}
	}
}
