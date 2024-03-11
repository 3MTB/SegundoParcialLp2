namespace SegundoParcialLp2.Forms
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnClear = new Button();
			btnAgregar = new Button();
			DGV_Empleados = new DataGridView();
			DataTimeEmpleado = new DateTimePicker();
			MTB_Cedula = new MaskedTextBox();
			MTB_Telefono = new MaskedTextBox();
			label10 = new Label();
			label9 = new Label();
			TB_Direccion = new TextBox();
			label8 = new Label();
			label7 = new Label();
			TB_Correo = new TextBox();
			label6 = new Label();
			CB_Cargo = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			TB_Apellido = new TextBox();
			label2 = new Label();
			CB_Departamento = new ComboBox();
			TB_Nombre = new TextBox();
			label1 = new Label();
			TB_Sueldo = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)DGV_Empleados).BeginInit();
			((System.ComponentModel.ISupportInitialize)TB_Sueldo).BeginInit();
			SuspendLayout();
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.Teal;
			btnClear.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnClear.FlatStyle = FlatStyle.Flat;
			btnClear.ForeColor = Color.White;
			btnClear.Location = new Point(661, 249);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(151, 51);
			btnClear.TabIndex = 53;
			btnClear.Text = "Limpiar";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.Teal;
			btnAgregar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnAgregar.FlatStyle = FlatStyle.Flat;
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(465, 249);
			btnAgregar.Margin = new Padding(3, 4, 3, 4);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(151, 51);
			btnAgregar.TabIndex = 51;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// DGV_Empleados
			// 
			DGV_Empleados.BackgroundColor = Color.White;
			DGV_Empleados.BorderStyle = BorderStyle.Fixed3D;
			DGV_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_Empleados.Enabled = false;
			DGV_Empleados.Location = new Point(12, 331);
			DGV_Empleados.Margin = new Padding(3, 4, 3, 4);
			DGV_Empleados.Name = "DGV_Empleados";
			DGV_Empleados.RowHeadersWidth = 51;
			DGV_Empleados.Size = new Size(890, 475);
			DGV_Empleados.TabIndex = 50;
			DGV_Empleados.CellContentClick += DGV_Empleados_CellContentClick;
			// 
			// DataTimeEmpleado
			// 
			DataTimeEmpleado.Format = DateTimePickerFormat.Short;
			DataTimeEmpleado.Location = new Point(661, 187);
			DataTimeEmpleado.Margin = new Padding(3, 4, 3, 4);
			DataTimeEmpleado.Name = "DataTimeEmpleado";
			DataTimeEmpleado.Size = new Size(206, 27);
			DataTimeEmpleado.TabIndex = 49;
			// 
			// MTB_Cedula
			// 
			MTB_Cedula.Location = new Point(231, 147);
			MTB_Cedula.Margin = new Padding(3, 4, 3, 4);
			MTB_Cedula.Mask = "000-0000000-0";
			MTB_Cedula.Name = "MTB_Cedula";
			MTB_Cedula.Size = new Size(206, 27);
			MTB_Cedula.TabIndex = 48;
			// 
			// MTB_Telefono
			// 
			MTB_Telefono.Location = new Point(661, 71);
			MTB_Telefono.Margin = new Padding(3, 4, 3, 4);
			MTB_Telefono.Mask = "000-000-0000";
			MTB_Telefono.Name = "MTB_Telefono";
			MTB_Telefono.Size = new Size(206, 27);
			MTB_Telefono.TabIndex = 47;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Century Gothic", 14.25F);
			label10.Location = new Point(445, 187);
			label10.Name = "label10";
			label10.Size = new Size(168, 30);
			label10.TabIndex = 46;
			label10.Text = "Fecha Contr.";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Century Gothic", 14.25F);
			label9.Location = new Point(445, 148);
			label9.Name = "label9";
			label9.Size = new Size(94, 30);
			label9.TabIndex = 44;
			label9.Text = "Sueldo";
			// 
			// TB_Direccion
			// 
			TB_Direccion.Location = new Point(661, 109);
			TB_Direccion.Margin = new Padding(3, 4, 3, 4);
			TB_Direccion.Multiline = true;
			TB_Direccion.Name = "TB_Direccion";
			TB_Direccion.Size = new Size(206, 29);
			TB_Direccion.TabIndex = 43;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 14.25F);
			label8.Location = new Point(445, 109);
			label8.Name = "label8";
			label8.Size = new Size(129, 30);
			label8.TabIndex = 42;
			label8.Text = "Direccion";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 14.25F);
			label7.Location = new Point(445, 71);
			label7.Name = "label7";
			label7.Size = new Size(117, 30);
			label7.TabIndex = 41;
			label7.Text = "Telefono";
			// 
			// TB_Correo
			// 
			TB_Correo.Location = new Point(231, 271);
			TB_Correo.Margin = new Padding(3, 4, 3, 4);
			TB_Correo.Multiline = true;
			TB_Correo.Name = "TB_Correo";
			TB_Correo.Size = new Size(206, 29);
			TB_Correo.TabIndex = 40;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 14.25F);
			label6.Location = new Point(55, 271);
			label6.Name = "label6";
			label6.Size = new Size(95, 30);
			label6.TabIndex = 39;
			label6.Text = "Correo";
			// 
			// CB_Cargo
			// 
			CB_Cargo.FormattingEnabled = true;
			CB_Cargo.Location = new Point(231, 224);
			CB_Cargo.Margin = new Padding(3, 4, 3, 4);
			CB_Cargo.Name = "CB_Cargo";
			CB_Cargo.Size = new Size(206, 28);
			CB_Cargo.TabIndex = 38;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F);
			label5.Location = new Point(55, 225);
			label5.Name = "label5";
			label5.Size = new Size(88, 30);
			label5.TabIndex = 37;
			label5.Text = "Cargo";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 14.25F);
			label4.Location = new Point(55, 187);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(101, 30);
			label4.TabIndex = 36;
			label4.Text = "Depart.";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 14.25F);
			label3.Location = new Point(55, 148);
			label3.Name = "label3";
			label3.Size = new Size(102, 30);
			label3.TabIndex = 35;
			label3.Text = "Cedula";
			// 
			// TB_Apellido
			// 
			TB_Apellido.Location = new Point(231, 108);
			TB_Apellido.Margin = new Padding(3, 4, 3, 4);
			TB_Apellido.Multiline = true;
			TB_Apellido.Name = "TB_Apellido";
			TB_Apellido.Size = new Size(206, 29);
			TB_Apellido.TabIndex = 34;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 14.25F);
			label2.Location = new Point(55, 109);
			label2.Name = "label2";
			label2.Size = new Size(112, 30);
			label2.TabIndex = 33;
			label2.Text = "Apellido";
			// 
			// CB_Departamento
			// 
			CB_Departamento.FormattingEnabled = true;
			CB_Departamento.Location = new Point(231, 185);
			CB_Departamento.Margin = new Padding(3, 4, 3, 4);
			CB_Departamento.Name = "CB_Departamento";
			CB_Departamento.Size = new Size(206, 28);
			CB_Departamento.TabIndex = 32;
			// 
			// TB_Nombre
			// 
			TB_Nombre.Location = new Point(231, 69);
			TB_Nombre.Margin = new Padding(3, 4, 3, 4);
			TB_Nombre.Multiline = true;
			TB_Nombre.Name = "TB_Nombre";
			TB_Nombre.Size = new Size(206, 29);
			TB_Nombre.TabIndex = 31;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 14.25F);
			label1.Location = new Point(55, 71);
			label1.Name = "label1";
			label1.Size = new Size(110, 30);
			label1.TabIndex = 30;
			label1.Text = "Nombre";
			// 
			// TB_Sueldo
			// 
			TB_Sueldo.Location = new Point(662, 151);
			TB_Sueldo.Margin = new Padding(0);
			TB_Sueldo.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			TB_Sueldo.Name = "TB_Sueldo";
			TB_Sueldo.Size = new Size(150, 27);
			TB_Sueldo.TabIndex = 54;
			TB_Sueldo.ThousandsSeparator = true;
			// 
			// FrmEmpleados
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(914, 952);
			Controls.Add(TB_Sueldo);
			Controls.Add(btnClear);
			Controls.Add(btnAgregar);
			Controls.Add(DGV_Empleados);
			Controls.Add(DataTimeEmpleado);
			Controls.Add(MTB_Cedula);
			Controls.Add(MTB_Telefono);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(TB_Direccion);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(TB_Correo);
			Controls.Add(label6);
			Controls.Add(CB_Cargo);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(TB_Apellido);
			Controls.Add(label2);
			Controls.Add(CB_Departamento);
			Controls.Add(TB_Nombre);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmEmpleados";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Empleados";
			Load += FrmEmpleados_Load;
			((System.ComponentModel.ISupportInitialize)DGV_Empleados).EndInit();
			((System.ComponentModel.ISupportInitialize)TB_Sueldo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnClear;
        private Button btnAgregar;
        private DataGridView DGV_Empleados;
        private DateTimePicker DataTimeEmpleado;
        private MaskedTextBox MTB_Cedula;
        private MaskedTextBox MTB_Telefono;
        private Label label10;
        private Label label9;
        private TextBox TB_Direccion;
        private Label label8;
        private Label label7;
        private TextBox TB_Correo;
        private Label label6;
        private ComboBox CB_Cargo;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TB_Apellido;
        private Label label2;
        private ComboBox CB_Departamento;
        private TextBox TB_Nombre;
        private Label label1;
		private NumericUpDown TB_Sueldo;
	}
}