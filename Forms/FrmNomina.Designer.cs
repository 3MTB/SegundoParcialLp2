namespace SegundoParcialLp2.Forms
{
    partial class FrmNomina
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
			btnBorrar = new Button();
			btnClear = new Button();
			btnModificar = new Button();
			btnAgregar = new Button();
			DGV_Empleados = new DataGridView();
			TB_Correo = new TextBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			DataTimeEmpleado = new DateTimePicker();
			label10 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			comboBox3 = new ComboBox();
			((System.ComponentModel.ISupportInitialize)DGV_Empleados).BeginInit();
			SuspendLayout();
			// 
			// btnBorrar
			// 
			btnBorrar.BackColor = Color.DarkRed;
			btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
			btnBorrar.FlatStyle = FlatStyle.Flat;
			btnBorrar.ForeColor = Color.White;
			btnBorrar.Location = new Point(718, 823);
			btnBorrar.Margin = new Padding(3, 4, 3, 4);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(146, 51);
			btnBorrar.TabIndex = 79;
			btnBorrar.Text = "Borrar";
			btnBorrar.UseVisualStyleBackColor = false;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.Teal;
			btnClear.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnClear.FlatStyle = FlatStyle.Flat;
			btnClear.ForeColor = Color.White;
			btnClear.Location = new Point(695, 216);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(151, 51);
			btnClear.TabIndex = 78;
			btnClear.Text = "Limpiar";
			btnClear.UseVisualStyleBackColor = false;
			// 
			// btnModificar
			// 
			btnModificar.BackColor = Color.Teal;
			btnModificar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnModificar.FlatStyle = FlatStyle.Flat;
			btnModificar.ForeColor = Color.White;
			btnModificar.Location = new Point(551, 823);
			btnModificar.Margin = new Padding(3, 4, 3, 4);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(146, 51);
			btnModificar.TabIndex = 77;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = false;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.Teal;
			btnAgregar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnAgregar.FlatStyle = FlatStyle.Flat;
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(499, 216);
			btnAgregar.Margin = new Padding(3, 4, 3, 4);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(151, 51);
			btnAgregar.TabIndex = 76;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			// 
			// DGV_Empleados
			// 
			DGV_Empleados.BackgroundColor = Color.White;
			DGV_Empleados.BorderStyle = BorderStyle.Fixed3D;
			DGV_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_Empleados.Location = new Point(51, 340);
			DGV_Empleados.Margin = new Padding(3, 4, 3, 4);
			DGV_Empleados.Name = "DGV_Empleados";
			DGV_Empleados.RowHeadersWidth = 51;
			DGV_Empleados.Size = new Size(813, 475);
			DGV_Empleados.TabIndex = 75;
			// 
			// TB_Correo
			// 
			TB_Correo.Location = new Point(639, 128);
			TB_Correo.Margin = new Padding(3, 4, 3, 4);
			TB_Correo.Multiline = true;
			TB_Correo.Name = "TB_Correo";
			TB_Correo.Size = new Size(206, 29);
			TB_Correo.TabIndex = 65;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 14.25F);
			label6.Location = new Point(441, 124);
			label6.Name = "label6";
			label6.Size = new Size(159, 30);
			label6.TabIndex = 64;
			label6.Text = "Sueldo Neto";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F);
			label5.Location = new Point(441, 79);
			label5.Name = "label5";
			label5.Size = new Size(174, 30);
			label5.TabIndex = 62;
			label5.Text = "Seguro Social";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 14.25F);
			label4.Location = new Point(51, 196);
			label4.Name = "label4";
			label4.Size = new Size(87, 30);
			label4.TabIndex = 61;
			label4.Text = "IdCxC";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 14.25F);
			label3.Location = new Point(51, 157);
			label3.Name = "label3";
			label3.Size = new Size(56, 30);
			label3.TabIndex = 60;
			label3.Text = "AFP";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 14.25F);
			label2.Location = new Point(51, 119);
			label2.Name = "label2";
			label2.Size = new Size(158, 30);
			label2.TabIndex = 58;
			label2.Text = "IdEmpleado";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 14.25F);
			label1.Location = new Point(51, 80);
			label1.Name = "label1";
			label1.Size = new Size(203, 30);
			label1.TabIndex = 55;
			label1.Text = "Tipo de Nomina";
			// 
			// DataTimeEmpleado
			// 
			DataTimeEmpleado.Format = DateTimePickerFormat.Short;
			DataTimeEmpleado.Location = new Point(639, 167);
			DataTimeEmpleado.Margin = new Padding(3, 4, 3, 4);
			DataTimeEmpleado.Name = "DataTimeEmpleado";
			DataTimeEmpleado.Size = new Size(206, 27);
			DataTimeEmpleado.TabIndex = 81;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Century Gothic", 14.25F);
			label10.Location = new Point(441, 167);
			label10.Name = "label10";
			label10.Size = new Size(88, 30);
			label10.TabIndex = 80;
			label10.Text = "Fecha";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(639, 84);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(206, 29);
			textBox1.TabIndex = 82;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(227, 157);
			textBox2.Margin = new Padding(3, 4, 3, 4);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(206, 29);
			textBox2.TabIndex = 83;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(227, 80);
			comboBox1.Margin = new Padding(3, 4, 3, 4);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(206, 28);
			comboBox1.TabIndex = 85;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(227, 119);
			comboBox2.Margin = new Padding(3, 4, 3, 4);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(206, 28);
			comboBox2.TabIndex = 86;
			// 
			// comboBox3
			// 
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(227, 200);
			comboBox3.Margin = new Padding(3, 4, 3, 4);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(206, 28);
			comboBox3.TabIndex = 87;
			// 
			// FrmNomina
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(914, 952);
			Controls.Add(comboBox3);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(DataTimeEmpleado);
			Controls.Add(label10);
			Controls.Add(btnBorrar);
			Controls.Add(btnClear);
			Controls.Add(btnModificar);
			Controls.Add(btnAgregar);
			Controls.Add(DGV_Empleados);
			Controls.Add(TB_Correo);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmNomina";
			Text = "Nomina";
			((System.ComponentModel.ISupportInitialize)DGV_Empleados).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBorrar;
        private Button btnClear;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView DGV_Empleados;
        private TextBox TB_Correo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker DataTimeEmpleado;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}