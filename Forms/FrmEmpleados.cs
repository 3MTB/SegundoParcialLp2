using SegundoParcialLp2.Data.Gestor;
using SegundoParcialLp2.Models;
using static SegundoParcialLp2.Models.Functions;

namespace SegundoParcialLp2.Forms
{
	public partial class FrmEmpleados : Form
	{
		public bool isFranly { get; set; }
		public FrmEmpleados(bool isFranly)
		{
			InitializeComponent();
			this.isFranly = isFranly;

		}
		public void MyIniciador()
		{
			List<string> departamentos = new List<string>(){
   "Administracion", "Contabilidad","Limpieza"
			};
			List<string> cargos = new List<string>(){
   "Tecnico","Limpieza","Secretari@"
			};
			CB_Departamento.DataSource = departamentos;
			CB_Cargo.DataSource = cargos;
			ActualizaDgEmpleado();
		}
		private void ActualizaDgEmpleado()
		{
			DGV_Empleados.DataSource = null;
			DGV_Empleados.DataSource = gestorEmpleado.GetEmpleados(isFranly);
		}
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			VerificaEmpleado();
		}
		private void VerificaEmpleado()
		{
			if (VerificaString(TB_Nombre.Text) && VerificaString(TB_Apellido.Text) && VerificaString(MTB_Cedula.Text) && VerificaString(CB_Departamento.Text) && VerificaString(CB_Cargo.Text) && VerificaString(TB_Correo.Text) && VerificaString(MTB_Telefono.Text) && VerificaString(TB_Direccion.Text) && decimal.TryParse(TB_Sueldo.Text, out decimal sueldo) && DataTimeEmpleado.Value <= DateTime.Now)
			{
				string cedula = string.Empty;
				foreach (char x in MTB_Cedula.Text.Replace('-', ' '))
				{
					if (x != ' ')
					{
						cedula += x;
					}
				}
				Empleado empleado = new Empleado(TB_Nombre.Text, TB_Apellido.Text,cedula, CB_Departamento.Text, CB_Cargo.Text, TB_Correo.Text, MTB_Telefono.Text, TB_Direccion.Text, sueldo, DateOnly.FromDateTime(DataTimeEmpleado.Value));
				gestorEmpleado.InsertaEmpleado(empleado, isFranly);
				LimpiaCampos();
				ActualizaDgEmpleado();

			}
			else
			{
				if (!VerificaString(TB_Nombre.Text))
				{
					TB_Nombre.Focus();
					MessageBox.Show("Introduce un nombre", "CAMPO VACIO");
				}
				else if (!VerificaString(TB_Apellido.Text))
				{
					TB_Apellido.Focus();
					MessageBox.Show("Introduce APELLIDO", "CAMPO VACIO");
				}
				else if (!VerificaString(MTB_Cedula.Text))
				{
					MTB_Cedula.Focus();
					MessageBox.Show("Introduce Cedula", "CAMPO VACIO");
				}
				else if (!VerificaString(CB_Departamento.Text))
				{
					CB_Departamento.Focus();
					MessageBox.Show("Selecciona un departamento", "CAMPO VACIO");
				}
				else if (!VerificaString(CB_Cargo.Text))
				{
					CB_Cargo.Focus();
					MessageBox.Show("Selecciona un Cargo", "CAMPO VACIO");
				}
				else if (!VerificaString(TB_Correo.Text))
				{
					TB_Correo.Focus();
					MessageBox.Show("Ingresa un Correo", "CAMPO VACIO");
				}
				else if (!VerificaString(MTB_Telefono.Text))
				{
					MTB_Telefono.Focus();
					MessageBox.Show("Ingresa un Teléfono", "CAMPO VACIO");
				}
				else if (!VerificaString(TB_Direccion.Text))
				{
					TB_Direccion.Focus();
					MessageBox.Show("Ingresa una Dirección", "CAMPO VACIO");
				}
				else if (!decimal.TryParse(TB_Sueldo.Text, out decimal result))
				{
					TB_Sueldo.Focus();
					MessageBox.Show("Ingresa un sueldo Correcto", "CAMPO Incorrecto");

				}
				else if (DataTimeEmpleado.Value > DateTime.Now)
				{
					DataTimeEmpleado.Focus();
					MessageBox.Show("Fecha Empleado no puede ser superior a la fecha actual", "CAMPO Incorrecto");
				}
			}

		}

		private void TB_Sueldo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!decimal.TryParse(TB_Sueldo.Text, out decimal result))
			{
				MessageBox.Show("Solo se permiten decimales en sueldo");
				btnAgregar.Enabled = false;
			}
			else
			{
				btnAgregar.Enabled = true;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			LimpiaCampos();
		}
		private void LimpiaCampos()
		{
			TB_Nombre.Text = string.Empty;
			TB_Apellido.Text = string.Empty;
			MTB_Cedula.Text = string.Empty;
			TB_Correo.Text = string.Empty;
			MTB_Telefono.Text = string.Empty;
			TB_Direccion.Text = string.Empty;
			TB_Sueldo.Text = string.Empty;
		}

		private void FrmEmpleados_Load(object sender, EventArgs e)
		{
			MyIniciador();
		}
	}
}
