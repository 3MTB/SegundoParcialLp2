using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialLp2.Forms
{
	public partial class DashBoard : Form
	{
		public DashBoard()
		{
			InitializeComponent();
		}
		private Form activateForm = null!;

		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activateForm != null)
			{
				activateForm.Close();
			}
			activateForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesk.Controls.Add(childForm);
			this.panelDesk.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			LbT_NameVtn.Text = childForm.Text;
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEmpleados_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmEmpleados(), sender);
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmHome(), sender);
		}

		private void btnGastos_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmGastos(), sender);
		}

		private void btnCxC_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmCxC(), sender);
		}

		private void btnNomina_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmNomina(), sender);
		}

		private void DashBoard_Load(object sender, EventArgs e)
		{
			OpenChildForm(new FrmHome(), btnInicio);

		}
	}
}
