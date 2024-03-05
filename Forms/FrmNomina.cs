using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Modes;
using SegundoParcialLp2.Data.Gestor;
using SegundoParcialLp2.Models;

namespace SegundoParcialLp2.Forms
{
	public partial class FrmNomina : Form
	{
		public bool isFranly { get; set; }
		public FrmNomina(bool isFranly)
		{
			InitializeComponent();
			this.isFranly = isFranly;
		}

		private void FrmNomina_Load(object sender, EventArgs e)
		{
			string[] tipoNominas = ["Semanal", "Quincenal", "Mensual"];
			cbTipoNomina.DataSource = tipoNominas;
			cbIdCxc.DataSource = gestorCxc.GetCxcs(isFranly);
			cbIdCxc.DisplayMember = "ID";
			cbIdEmpleado.DataSource = gestorEmpleado.GetEmpleados(isFranly);
			cbIdEmpleado.DisplayMember = "Nombre";

			cbAFP.DataSource = Functions.aFPs;
			cbAFP.DisplayMember = "Nombre";
			ActualizaDgNomina();
		}
		private void ActualizaDgNomina()
		{
			dgvNomina.DataSource = null;
			dgvNomina.DataSource = gestorNomina.GetNominas(isFranly);
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			VerificaValores();
		}
		private void VerificaValores()
		{
			try
			{
				var empleado = (Empleado)cbIdEmpleado.SelectedItem;
				if (empleado != null)
				{
					var cxc = (CxC)cbIdCxc.SelectedItem;
					if (cxc != null)
					{
						var afp = (AFP)cbAFP.SelectedItem;

						if (afp != null)
						{
							if (decimal.TryParse(tbSeguroSocial.Text, out decimal seguroSocial))
							{
								Nomina nomina = new Nomina(cbTipoNomina.Text, empleado.ID, afp.descontar, cxc.ID, seguroSocial);
								gestorNomina.InsertNomina(nomina, isFranly);
								ActualizaDgNomina();
							}
							else
							{
								MessageBox.Show($"FALLO AL MOMENTO DE Obtener el monto correspondiente al seguro social:::");

							}
						}
						else
						{
							MessageBox.Show($"FALLO AL MOMENTO DE Obtener el monto correspondiente a la AFP:::");
						}
					}
					else
					{
						MessageBox.Show($"FALLO AL MOMENTO DE Obtener el ID CXC:::");
					}
				}
				else
				{
					MessageBox.Show($"FALLO AL MOMENTO DE Obtener el empleado:::");
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($"FALLO AL MOMENTO DE PROCESAR LOS DATOS DE NOMINA:::{e.Message}");
			}
		}
	}
}
