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

			ApplicationConfiguration.Initialize();
			var testing = new TestIngDb();
			var DBoard = new DashBoard();
			Application.Run(testing);

		}
	}
}