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
using static SegundoParcialLp2.Models.Functions;


namespace SegundoParcialLp2.Forms
{
	public partial class FrmGastos : Form
	{
		public bool isFranly { get; set; }
		public FrmGastos(bool isFranly)
		{
			InitializeComponent();
			this.isFranly = isFranly;
		}

		private void FrmGastos_Load(object sender, EventArgs e)
		{
			MyIniciador();
		}


		private void MyIniciador()
		{
			string[] cajas = new string[] { "1", "2", "3" };
			CB_NumeroCaja.DataSource = cajas;
			string[] Autorizadores = new string[] { "EURY", "FRANLY", "DILONE", "ADMIN" };
			CB_QuienAutoriza.DataSource = Autorizadores;
			ActualizaGastos();
		}

		private void checkPagaNomina_CheckedChanged(object sender, EventArgs e)
		{
			if (checkPagaNomina.Checked)
			{
				cbNomina.DataSource = null;
				cbNomina.DataSource = gestorNomina.GetNominas(isFranly);
				cbNomina.DisplayMember = "ID";
			}
			cbNomina.Visible = checkPagaNomina.Checked;
			tbTotalGasto.Enabled = !checkPagaNomina.Checked;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			VerificaDatos();
			ActualizaGastos();

		}
		private void VerificaDatos()
		{

			if (VerificaString(CB_NumeroCaja.Text) && int.TryParse(CB_NumeroCaja.Text, out int numeroCaja) && VerificaString(TB_ConceptoGastos.Text) && decimal.TryParse(tbTotalGasto.Text, out decimal total) && VerificaString(CB_QuienAutoriza.Text) && VerificaString(TB_QuienRecibe.Text) && Dt_FechaGasto.Value <= DateTime.Now)
			{
				Gasto gasto = new Gasto(numeroCaja, TB_ConceptoGastos.Text, total, CB_QuienAutoriza.Text, TB_QuienRecibe.Text, DateOnly.FromDateTime(Dt_FechaGasto.Value));
				gestorGasto.InsertaGasto(gasto, isFranly);
			}
			else
			{
				if (!VerificaString(CB_NumeroCaja.Text))
				{
					CB_NumeroCaja.Focus();
					MessageBox.Show("Selecciona una CAJA", "CAMPO VACIO");
				}
				else if (!int.TryParse(CB_NumeroCaja.Text, out _))
				{
					CB_NumeroCaja.Focus();
					MessageBox.Show("Numero Caja Solo acepta numeros enteros", "CAMPO VACIO");
				}
				else if (!VerificaString(TB_ConceptoGastos.Text))
				{
					TB_ConceptoGastos.Focus();
					MessageBox.Show("DEBES AÑADIR UNA DESCRIPCION", "CAMPO VACIO");
				}
				else if (!decimal.TryParse(tbTotalGasto.Text, out _))
				{
					tbTotalGasto.Focus();
					MessageBox.Show("DEBES AÑADIR UN MONTO", "CAMPO VACIO");
				}
				else if (!VerificaString(CB_QuienAutoriza.Text))
				{
					CB_QuienAutoriza.Focus();
					MessageBox.Show("Faltan los datos de la persona que autoriza", "CAMPO VACIO");
				}
				else if (!VerificaString(TB_QuienRecibe.Text))
				{
					TB_QuienRecibe.Focus();
					MessageBox.Show("Faltan los datos de la persona que RECIBE", "CAMPO VACIO");
				}
				else if (Dt_FechaGasto.Value > DateTime.Now)
				{
					Dt_FechaGasto.Focus();
					MessageBox.Show("No puedes poner una fecha que aun no llega", "CAMPO Incorrecto");
				}
			}
		}

		private void cbNomina_SelectedIndexChanged(object sender, EventArgs e)
		{
			var nominaActual = (Nomina)cbNomina.SelectedItem;
			if (nominaActual != null)
			{
				tbTotalGasto.Text = nominaActual.SueldoNeto.ToString();
			}
			else
			{
				MessageBox.Show("ERROR al momento de procesar la nomina a pagar", "ERROR");

			}
			TB_ConceptoGastos.Text = $"PAGO NOMINA CORRESPONDIENTE Al EMPLEADO: {((Nomina)cbNomina.SelectedItem).ID}";
		}

		private void TB_ConceptoGastos_TextChanged(object sender, EventArgs e)
		{
			if (!VerificaString(TB_ConceptoGastos.Text))
			{
				TB_ConceptoGastos.Text = "PAGO General....";
			}
		}

		private void ActualizaGastos()
		{
			DGV_Gastos.DataSource = null;
			DGV_Gastos.DataSource = gestorGasto.getGastos(isFranly);
		}

	}
}
