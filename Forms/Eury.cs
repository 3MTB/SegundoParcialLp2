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
	public partial class Eury : Form
	{
		public Eury()
		{
			InitializeComponent();
		}

		private void Eury_Load(object sender, EventArgs e)
		{
			string[] opc = ["FRANLY", "EURY"];
			cbOptions.DataSource = opc;
		}

		private void btnTry_Click(object sender, EventArgs e)
		{
			AmbarDataBase db = new AmbarDataBase(cbOptions.Text == "FRANLY");
			if (db.GetConection() == null)
			{
				MessageBox.Show("Algo fallo al momento de contextar a la base de datos - User:" + cbOptions.Text);
			}
			else
			{
				MessageBox.Show("Correct conection - User:" + cbOptions.Text);
			}
		}
	}
}
