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
			dgvNomina = new DataGridView();
			tbSueldoNeto = new TextBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			tbSeguroSocial = new TextBox();
			cbTipoNomina = new ComboBox();
			cbIdEmpleado = new ComboBox();
			cbIdCxc = new ComboBox();
			cbAFP = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
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
			btnAgregar.Click += btnAgregar_Click;
			// 
			// dgvNomina
			// 
			dgvNomina.BackgroundColor = Color.White;
			dgvNomina.BorderStyle = BorderStyle.Fixed3D;
			dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvNomina.Location = new Point(51, 340);
			dgvNomina.Margin = new Padding(3, 4, 3, 4);
			dgvNomina.Name = "dgvNomina";
			dgvNomina.RowHeadersWidth = 51;
			dgvNomina.Size = new Size(813, 475);
			dgvNomina.TabIndex = 75;
			// 
			// tbSueldoNeto
			// 
			tbSueldoNeto.Enabled = false;
			tbSueldoNeto.Location = new Point(639, 128);
			tbSueldoNeto.Margin = new Padding(3, 4, 3, 4);
			tbSueldoNeto.Multiline = true;
			tbSueldoNeto.Name = "tbSueldoNeto";
			tbSueldoNeto.Size = new Size(206, 29);
			tbSueldoNeto.TabIndex = 65;
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
			// tbSeguroSocial
			// 
			tbSeguroSocial.Location = new Point(639, 84);
			tbSeguroSocial.Margin = new Padding(3, 4, 3, 4);
			tbSeguroSocial.Multiline = true;
			tbSeguroSocial.Name = "tbSeguroSocial";
			tbSeguroSocial.Size = new Size(206, 29);
			tbSeguroSocial.TabIndex = 82;
			// 
			// cbTipoNomina
			// 
			cbTipoNomina.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTipoNomina.FormattingEnabled = true;
			cbTipoNomina.Location = new Point(227, 80);
			cbTipoNomina.Margin = new Padding(3, 4, 3, 4);
			cbTipoNomina.Name = "cbTipoNomina";
			cbTipoNomina.Size = new Size(206, 28);
			cbTipoNomina.TabIndex = 85;
			// 
			// cbIdEmpleado
			// 
			cbIdEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
			cbIdEmpleado.FormattingEnabled = true;
			cbIdEmpleado.Location = new Point(227, 119);
			cbIdEmpleado.Margin = new Padding(3, 4, 3, 4);
			cbIdEmpleado.Name = "cbIdEmpleado";
			cbIdEmpleado.Size = new Size(206, 28);
			cbIdEmpleado.TabIndex = 86;
			// 
			// cbIdCxc
			// 
			cbIdCxc.DropDownStyle = ComboBoxStyle.DropDownList;
			cbIdCxc.FormattingEnabled = true;
			cbIdCxc.Location = new Point(227, 200);
			cbIdCxc.Margin = new Padding(3, 4, 3, 4);
			cbIdCxc.Name = "cbIdCxc";
			cbIdCxc.Size = new Size(206, 28);
			cbIdCxc.TabIndex = 87;
			// 
			// cbAFP
			// 
			cbAFP.DropDownStyle = ComboBoxStyle.DropDownList;
			cbAFP.FormattingEnabled = true;
			cbAFP.Location = new Point(227, 164);
			cbAFP.Margin = new Padding(3, 4, 3, 4);
			cbAFP.Name = "cbAFP";
			cbAFP.Size = new Size(206, 28);
			cbAFP.TabIndex = 88;
			// 
			// FrmNomina
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(914, 952);
			Controls.Add(cbAFP);
			Controls.Add(cbIdCxc);
			Controls.Add(cbIdEmpleado);
			Controls.Add(cbTipoNomina);
			Controls.Add(tbSeguroSocial);
			Controls.Add(btnBorrar);
			Controls.Add(btnClear);
			Controls.Add(btnModificar);
			Controls.Add(btnAgregar);
			Controls.Add(dgvNomina);
			Controls.Add(tbSueldoNeto);
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
			Load += FrmNomina_Load;
			((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBorrar;
        private Button btnClear;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvNomina;
        private TextBox tbSueldoNeto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSeguroSocial;
        private ComboBox cbTipoNomina;
        private ComboBox cbIdEmpleado;
        private ComboBox cbIdCxc;
		private ComboBox cbAFP;
	}
}