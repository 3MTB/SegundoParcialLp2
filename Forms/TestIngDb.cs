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
	}
}
