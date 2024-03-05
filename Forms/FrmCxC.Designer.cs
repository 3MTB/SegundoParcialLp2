namespace SegundoParcialLp2.Forms
{
    partial class FrmCxC
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
			CB_IdEmpleado = new ComboBox();
			btnBorrar = new Button();
			btnClear = new Button();
			btnModificar = new Button();
			btnAgregar = new Button();
			DGV_Cxc = new DataGridView();
			Dt_FechaPrestamo = new DateTimePicker();
			label10 = new Label();
			label2 = new Label();
			label1 = new Label();
			CB_TotalCxC = new ComboBox();
			((System.ComponentModel.ISupportInitialize)DGV_Cxc).BeginInit();
			SuspendLayout();
			// 
			// CB_IdEmpleado
			// 
			CB_IdEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
			CB_IdEmpleado.FormattingEnabled = true;
			CB_IdEmpleado.Location = new Point(287, 92);
			CB_IdEmpleado.Margin = new Padding(3, 4, 3, 4);
			CB_IdEmpleado.Name = "CB_IdEmpleado";
			CB_IdEmpleado.Size = new Size(206, 28);
			CB_IdEmpleado.TabIndex = 97;
			// 
			// btnBorrar
			// 
			btnBorrar.BackColor = Color.DarkRed;
			btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
			btnBorrar.FlatStyle = FlatStyle.Flat;
			btnBorrar.ForeColor = Color.White;
			btnBorrar.Location = new Point(697, 151);
			btnBorrar.Margin = new Padding(3, 4, 3, 4);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(151, 51);
			btnBorrar.TabIndex = 96;
			btnBorrar.Text = "Borrar";
			btnBorrar.UseVisualStyleBackColor = false;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.Teal;
			btnClear.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnClear.FlatStyle = FlatStyle.Flat;
			btnClear.ForeColor = Color.White;
			btnClear.Location = new Point(697, 92);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(151, 51);
			btnClear.TabIndex = 95;
			btnClear.Text = "Limpiar";
			btnClear.UseVisualStyleBackColor = false;
			// 
			// btnModificar
			// 
			btnModificar.BackColor = Color.Teal;
			btnModificar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnModificar.FlatStyle = FlatStyle.Flat;
			btnModificar.ForeColor = Color.White;
			btnModificar.Location = new Point(527, 152);
			btnModificar.Margin = new Padding(3, 4, 3, 4);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(151, 51);
			btnModificar.TabIndex = 94;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = false;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.Teal;
			btnAgregar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
			btnAgregar.FlatStyle = FlatStyle.Flat;
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(527, 92);
			btnAgregar.Margin = new Padding(3, 4, 3, 4);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(151, 51);
			btnAgregar.TabIndex = 93;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// DGV_Cxc
			// 
			DGV_Cxc.BackgroundColor = Color.White;
			DGV_Cxc.BorderStyle = BorderStyle.Fixed3D;
			DGV_Cxc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_Cxc.Location = new Point(48, 253);
			DGV_Cxc.Margin = new Padding(3, 4, 3, 4);
			DGV_Cxc.Name = "DGV_Cxc";
			DGV_Cxc.RowHeadersWidth = 51;
			DGV_Cxc.Size = new Size(813, 571);
			DGV_Cxc.TabIndex = 92;
			// 
			// Dt_FechaPrestamo
			// 
			Dt_FechaPrestamo.Format = DateTimePickerFormat.Short;
			Dt_FechaPrestamo.Location = new Point(287, 169);
			Dt_FechaPrestamo.Margin = new Padding(3, 4, 3, 4);
			Dt_FechaPrestamo.Name = "Dt_FechaPrestamo";
			Dt_FechaPrestamo.Size = new Size(206, 27);
			Dt_FechaPrestamo.TabIndex = 91;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Century Gothic", 14.25F);
			label10.Location = new Point(56, 171);
			label10.Name = "label10";
			label10.Size = new Size(245, 30);
			label10.TabIndex = 90;
			label10.Text = "Fecha de Prestamo";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 14.25F);
			label2.Location = new Point(56, 132);
			label2.Name = "label2";
			label2.Size = new Size(129, 30);
			label2.TabIndex = 85;
			label2.Text = "Total CxC";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 14.25F);
			label1.Location = new Point(56, 93);
			label1.Name = "label1";
			label1.Size = new Size(165, 30);
			label1.TabIndex = 83;
			label1.Text = "Id Empleado";
			// 
			// CB_TotalCxC
			// 
			CB_TotalCxC.FormattingEnabled = true;
			CB_TotalCxC.Location = new Point(287, 131);
			CB_TotalCxC.Margin = new Padding(3, 4, 3, 4);
			CB_TotalCxC.Name = "CB_TotalCxC";
			CB_TotalCxC.Size = new Size(206, 28);
			CB_TotalCxC.TabIndex = 98;
			// 
			// FrmCxC
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(914, 952);
			Controls.Add(CB_TotalCxC);
			Controls.Add(CB_IdEmpleado);
			Controls.Add(btnBorrar);
			Controls.Add(btnClear);
			Controls.Add(btnModificar);
			Controls.Add(btnAgregar);
			Controls.Add(DGV_Cxc);
			Controls.Add(Dt_FechaPrestamo);
			Controls.Add(label10);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmCxC";
			Text = "CxC";
			Load += FrmCxC_Load;
			((System.ComponentModel.ISupportInitialize)DGV_Cxc).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox CB_IdEmpleado;
        private Button btnBorrar;
        private Button btnClear;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView DGV_Cxc;
        private DateTimePicker Dt_FechaPrestamo;
        private Label label10;
        private Label label2;
        private Label label1;
        private ComboBox CB_TotalCxC;
    }
}