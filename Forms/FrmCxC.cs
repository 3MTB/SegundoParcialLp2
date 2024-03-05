using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoParcialLp2.Data.Gestor;
using SegundoParcialLp2.Models;

namespace SegundoParcialLp2.Forms
{
	public partial class FrmCxC : Form
	{
		public bool isFranly { get; set; }
		public FrmCxC(bool isFranly)
		{
			InitializeComponent();
			this.isFranly = isFranly;
		}

		private void FrmCxC_Load(object sender, EventArgs e)
		{
			MyInitializer();
		}
		private void MyInitializer()
		{
			CB_IdEmpleado.DataSource = gestorEmpleado.GetEmpleados(isFranly);
			CB_IdEmpleado.DisplayMember = "Nombre";
			ActualizaDgCxc();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			verificaDatos();
			ActualizaDgCxc();
		}
		private void verificaDatos()
		{
			try
			{
				var empleado = (Empleado)CB_IdEmpleado.SelectedItem;
				if (empleado != null)
				{
					if (decimal.TryParse(CB_TotalCxC.Text, out decimal total))
					{
						if (Dt_FechaPrestamo.Value <= DateTime.Now)
						{
							CxC cxc = new CxC(empleado.ID, total, DateOnly.FromDateTime(Dt_FechaPrestamo.Value));
							gestorCxc.InsertaCxc(cxc, isFranly);

						}
						else
						{
							Dt_FechaPrestamo.Focus();
							MessageBox.Show("No puedes tener una fecha superior a la actual");

						}
					}
					else
					{
						CB_TotalCxC.Focus();
						MessageBox.Show("TOTAL CXC SOLO ACEPTA DECIMALES");
					}
				}
				else
				{
					MessageBox.Show("Error al obtener el cliente");

				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"FALLO AL MOMENTO DE PROCESAR LOS DATOS DE CXC:::{e.Message}");
			}
		}

		private void ActualizaDgCxc()
		{
			DGV_Cxc.DataSource = null;
			DGV_Cxc.DataSource = gestorCxc.GetCxcs(isFranly);
		}
	}
}
