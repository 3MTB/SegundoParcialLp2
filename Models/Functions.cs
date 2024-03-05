namespace SegundoParcialLp2.Models
{
	public class Functions
	{
		public static bool VerificaString(string verificar) => !string.IsNullOrWhiteSpace(verificar);

		public static AFP[] aFPs = new AFP[] { new AFP("ARS", 0.6m), new AFP("OTRA", 1.3m) };
	}
	public struct User
	{
		public const string Franly = "DESKTOP-SQ41TDR";
		public const string Eury = "DRAKO";
	}


	public record AFP(string Nombre, decimal descontar);
}
