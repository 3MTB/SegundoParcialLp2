namespace SegundoParcialLp2.Forms
{
    partial class FrmGastos
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
			DGV_Gastos = new DataGridView();
			Dt_FechaGasto = new DateTimePicker();
			label10 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			TB_QuienRecibe = new TextBox();
			label2 = new Label();
			TB_ConceptoGastos = new TextBox();
			label1 = new Label();
			CB_QuienAutoriza = new ComboBox();
			CB_NumeroCaja = new ComboBox();
			cbNomina = new ComboBox();
			label6 = new Label();
			tbTotalGasto = new TextBox();
			checkPagaNomina = new CheckBox();
			((System.ComponentModel.ISupportInitialize)DGV_Gastos).BeginInit();
			SuspendLayout();
			// 
			// btnBorrar
			// 
			btnBorrar.BackColor = Color.DarkRed;
			btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
			btnBorrar.FlatStyle = FlatStyle.Flat;
			btnBorrar.ForeColor = Color.White;
			btnBorrar.Location = new Point(716, 245);
			btnBorrar.Margin = new Padding(3, 4, 3, 4);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(151, 51);
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
			btnClear.Location = new Point(716, 186);
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
			btnModificar.Location = new Point(546, 246);
			btnModificar.Margin = new Padding(3, 4, 3, 4);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(151, 51);
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
			btnAgregar.Location = new Point(546, 186);
			btnAgregar.Margin = new Padding(3, 4, 3, 4);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(151, 51);
			btnAgregar.TabIndex = 76;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// DGV_Gastos
			// 
			DGV_Gastos.BackgroundColor = Color.White;
			DGV_Gastos.BorderStyle = BorderStyle.Fixed3D;
			DGV_Gastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_Gastos.Location = new Point(51, 320);
			DGV_Gastos.Margin = new Padding(3, 4, 3, 4);
			DGV_Gastos.Name = "DGV_Gastos";
			DGV_Gastos.RowHeadersWidth = 51;
			DGV_Gastos.Size = new Size(813, 571);
			DGV_Gastos.TabIndex = 75;
			// 
			// Dt_FechaGasto
			// 
			Dt_FechaGasto.Format = DateTimePickerFormat.Short;
			Dt_FechaGasto.Location = new Point(601, 61);
			Dt_FechaGasto.Margin = new Padding(3, 4, 3, 4);
			Dt_FechaGasto.Name = "Dt_FechaGasto";
			Dt_FechaGasto.Size = new Size(206, 27);
			Dt_FechaGasto.TabIndex = 74;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Century Gothic", 14.25F);
			label10.Location = new Point(516, 60);
			label10.Name = "label10";
			label10.Size = new Size(88, 30);
			label10.TabIndex = 71;
			label10.Text = "Fecha";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F);
			label5.Location = new Point(35, 264);
			label5.Name = "label5";
			label5.Size = new Size(164, 30);
			label5.TabIndex = 62;
			label5.Text = "Recibido Por";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 14.25F);
			label4.Location = new Point(35, 225);
			label4.Name = "label4";
			label4.Size = new Size(184, 30);
			label4.TabIndex = 61;
			label4.Text = "Autorizado Por";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 14.25F);
			label3.Location = new Point(35, 195);
			label3.Name = "label3";
			label3.Size = new Size(148, 30);
			label3.TabIndex = 60;
			label3.Text = "Total Gasto";
			// 
			// TB_QuienRecibe
			// 
			TB_QuienRecibe.Location = new Point(266, 262);
			TB_QuienRecibe.Margin = new Padding(3, 4, 3, 4);
			TB_QuienRecibe.Multiline = true;
			TB_QuienRecibe.Name = "TB_QuienRecibe";
			TB_QuienRecibe.Size = new Size(206, 29);
			TB_QuienRecibe.TabIndex = 59;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 14.25F);
			label2.Location = new Point(35, 99);
			label2.Name = "label2";
			label2.Size = new Size(253, 30);
			label2.TabIndex = 58;
			label2.Text = "Concepto de Gasto";
			// 
			// TB_ConceptoGastos
			// 
			TB_ConceptoGastos.Location = new Point(281, 100);
			TB_ConceptoGastos.Margin = new Padding(3, 4, 3, 4);
			TB_ConceptoGastos.Multiline = true;
			TB_ConceptoGastos.Name = "TB_ConceptoGastos";
			TB_ConceptoGastos.Size = new Size(206, 29);
			TB_ConceptoGastos.TabIndex = 56;
			TB_ConceptoGastos.TextChanged += TB_ConceptoGastos_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 14.25F);
			label1.Location = new Point(35, 60);
			label1.Name = "label1";
			label1.Size = new Size(212, 30);
			label1.TabIndex = 55;
			label1.Text = "Numero de Caja";
			// 
			// CB_QuienAutoriza
			// 
			CB_QuienAutoriza.DropDownStyle = ComboBoxStyle.DropDownList;
			CB_QuienAutoriza.FormattingEnabled = true;
			CB_QuienAutoriza.Location = new Point(266, 224);
			CB_QuienAutoriza.Margin = new Padding(3, 4, 3, 4);
			CB_QuienAutoriza.Name = "CB_QuienAutoriza";
			CB_QuienAutoriza.Size = new Size(206, 28);
			CB_QuienAutoriza.TabIndex = 81;
			// 
			// CB_NumeroCaja
			// 
			CB_NumeroCaja.DropDownStyle = ComboBoxStyle.DropDownList;
			CB_NumeroCaja.FormattingEnabled = true;
			CB_NumeroCaja.Location = new Point(266, 59);
			CB_NumeroCaja.Margin = new Padding(3, 4, 3, 4);
			CB_NumeroCaja.Name = "CB_NumeroCaja";
			CB_NumeroCaja.Size = new Size(206, 28);
			CB_NumeroCaja.TabIndex = 80;
			// 
			// cbNomina
			// 
			cbNomina.DropDownStyle = ComboBoxStyle.DropDownList;
			cbNomina.FormattingEnabled = true;
			cbNomina.Location = new Point(697, 142);
			cbNomina.Margin = new Padding(3, 4, 3, 4);
			cbNomina.Name = "cbNomina";
			cbNomina.Size = new Size(206, 28);
			cbNomina.TabIndex = 84;
			cbNomina.Visible = false;
			cbNomina.SelectedIndexChanged += cbNomina_SelectedIndexChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 14.25F);
			label6.Location = new Point(496, 136);
			label6.Name = "label6";
			label6.Size = new Size(0, 30);
			label6.TabIndex = 83;
			// 
			// tbTotalGasto
			// 
			tbTotalGasto.Location = new Point(266, 187);
			tbTotalGasto.Margin = new Padding(3, 4, 3, 4);
			tbTotalGasto.Multiline = true;
			tbTotalGasto.Name = "tbTotalGasto";
			tbTotalGasto.Size = new Size(206, 29);
			tbTotalGasto.TabIndex = 85;
			// 
			// checkPagaNomina
			// 
			checkPagaNomina.AutoSize = true;
			checkPagaNomina.Font = new Font("Century Gothic", 11F);
			checkPagaNomina.Location = new Point(532, 144);
			checkPagaNomina.Name = "checkPagaNomina";
			checkPagaNomina.Size = new Size(159, 26);
			checkPagaNomina.TabIndex = 86;
			checkPagaNomina.Text = "PagarNomina";
			checkPagaNomina.UseVisualStyleBackColor = true;
			checkPagaNomina.CheckedChanged += checkPagaNomina_CheckedChanged;
			// 
			// FrmGastos
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(914, 952);
			Controls.Add(checkPagaNomina);
			Controls.Add(tbTotalGasto);
			Controls.Add(cbNomina);
			Controls.Add(label6);
			Controls.Add(CB_QuienAutoriza);
			Controls.Add(CB_NumeroCaja);
			Controls.Add(btnBorrar);
			Controls.Add(btnClear);
			Controls.Add(btnModificar);
			Controls.Add(btnAgregar);
			Controls.Add(DGV_Gastos);
			Controls.Add(Dt_FechaGasto);
			Controls.Add(label10);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(TB_QuienRecibe);
			Controls.Add(label2);
			Controls.Add(TB_ConceptoGastos);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmGastos";
			Text = "Gastos";
			Load += FrmGastos_Load;
			((System.ComponentModel.ISupportInitialize)DGV_Gastos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBorrar;
        private Button btnClear;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView DGV_Gastos;
        private DateTimePicker Dt_FechaGasto;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TB_QuienRecibe;
        private Label label2;
        private TextBox TB_ConceptoGastos;
        private Label label1;
        private ComboBox CB_QuienAutoriza;
        private ComboBox CB_NumeroCaja;
		private ComboBox cbNomina;
		private Label label6;
		private TextBox tbTotalGasto;
		private CheckBox checkPagaNomina;
	}
}