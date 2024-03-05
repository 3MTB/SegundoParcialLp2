using SegundoParcialLp2.Forms;
using SegundoParcialLp2.Models;

namespace SegundoParcialLp2
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			ApplicationConfiguration.Initialize();
			// para determinar si es la computadora de Franly o No
			bool isFranly = Environment.UserDomainName == User.Franly;
			// para determinar si es la computadora de Franly o No
			var testing = new TestIngDb();
			var DBoard = new DashBoard(isFranly);
			Application.Run(new DashBoard(isFranly));

		}
	}
}