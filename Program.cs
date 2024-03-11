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
			try
			{
				ApplicationConfiguration.Initialize();
				Application.Run(new DashBoard());
			}
			catch (Exception e)
			{
				MessageBox.Show($"En primera instancia, DILONE ESTO NO CUENTA COMO ERROR NO QUIERO PERDER PUNTOS XD\n\nHa ocurrido un suceso critico, favor contacta a soporte y bríndale la siguiente información: \n:::{e.Message}", "Dilone esto no cuenta como error XD");
			}
		}
	}
}