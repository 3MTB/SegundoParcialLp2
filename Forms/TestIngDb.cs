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
using ZstdSharp.Unsafe;

namespace SegundoParcialLp2.Forms
{
	public partial class TestIngDb : Form
	{
		public bool isFranly { get; set; } = false;
		public TestIngDb()
		{
			InitializeComponent();
		}

		private void TestIngDb_Load(object sender, EventArgs e)
		{
			string[] opc = ["franly", "eury"];
			cbOption.DataSource = opc;
			cbOption.SelectedIndex = 1;
			isFranly = cbOption.Text == "franly";
			dgRegistro.DataSource = gestorEmpleado.GetEmpleados(isFranly);
			dgCxc.DataSource = gestorCxc.GetCxcs(isFranly);
		}

		private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
		{
			isFranly = cbOption.Text == "franly";

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
			await GuardarDefaultAsync();

		}
		private async Task GuardarDefaultAsync()
		{
			var fecha = DateOnly.FromDateTime(DateTime.Now);
			Empleado addDefault = new Empleado("Franly", "Leonardo", "04213131319", "REDES", "Tecnico", "User@gmail.com", "8097775555", "Fantino", 9000, fecha);
			await gestorEmpleado.InsertaEmpleado(addDefault, cbOption.Text == "franly");

			MessageBox.Show("mensaje de ejecucion");
			dgRegistro.DataSource = gestorEmpleado.GetEmpleados(cbOption.Text == "franly");
		}

		private void btnAddCxc_Click(object sender, EventArgs e)
		{
			GuardaDefaultCxC();
		}
		private async Task GuardaDefaultCxC()
		{
			var fecha = DateOnly.FromDateTime(DateTime.Now);
			CxC cxcDefault = new CxC(2, 200, fecha);
			await gestorCxc.InsertaCxc(cxcDefault, isFranly);
			dgCxc.DataSource = gestorCxc.GetCxcs(isFranly);

		}
	}
}
