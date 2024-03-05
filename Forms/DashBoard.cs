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
        public  bool isFranly { get; set; }
        public DashBoard(bool isFranly)
		{
			InitializeComponent();
			this.isFranly = isFranly;
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
			OpenChildForm(new FrmEmpleados(isFranly), sender);
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			if (activateForm != null)
			{
				activateForm.Close();
				LbT_NameVtn.Text = "Inicio";
			}
		}

		private void btnGastos_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmGastos(isFranly), sender);
		}

		private void btnCxC_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmCxC(isFranly), sender);
		}

		private void btnNomina_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmNomina(isFranly), sender);
		}

		private void DashBoard_Load(object sender, EventArgs e)
		{

		}
	}
}
