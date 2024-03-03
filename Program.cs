using SegundoParcialLp2.Forms;

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
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			var f = new TestIngDb();
			var DBoard = new DashBoard();
			Application.Run(DBoard);

			//EURYYYYY
			//hola fra
		}
	}
}