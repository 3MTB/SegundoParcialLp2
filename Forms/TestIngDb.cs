using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoParcialLp2.Data;
using SegundoParcialLp2.Data.Gestor;
using SegundoParcialLp2.Models;

namespace SegundoParcialLp2.Forms
{
	public partial class TestIngDb : Form
	{
		public TestIngDb()
		{
			InitializeComponent();
		}

		private void TestIngDb_Load(object sender, EventArgs e)
		{
			string[] opc = ["franly", "eury"];
			cbOption.DataSource = opc;
			cbOption.SelectedIndex = 1;
			dgRegistro.DataSource = gestorEmpleado.GetEmpleados(cbOption.Text == "franly");
		}

		private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnTry_Click(object sender, EventArgs e)
		{
			AmbarDataBase db = new AmbarDataBase(cbOption.Text == "franly");
			if (db.GetConection() == null)
			{
				MessageBox.Show("Error al conectar");
			}
			else
			{
				MessageBox.Show("Bien CABRON");

			}
		}

		private async void btnGuardar_ClickAsync(object sender, EventArgs e)
		{
		await 	GuardarDefaultAsync();

		}
		private async Task GuardarDefaultAsync()
		{
			var fecha = DateOnly.FromDateTime(DateTime.Now);
			Empleado addDefault = new Empleado("Franly", "Leonardo", "04213131319", "REDES", "Tecnico", "User@gmail.com", "8097775555", "Fantino", 9000, fecha);
			await gestorEmpleado.InsertaEmpleado(addDefault, cbOption.Text == "franly");

			MessageBox.Show("mensaje de ejecucion");
			dgRegistro.DataSource = gestorEmpleado.GetEmpleados(cbOption.Text == "franly");
		}
	}
}
