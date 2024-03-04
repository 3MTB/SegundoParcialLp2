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
            CB_TotalGasto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Gastos).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.DarkRed;
            btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(587, 131);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(132, 38);
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
            btnClear.Location = new Point(587, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 38);
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
            btnModificar.Location = new Point(438, 132);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 38);
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
            btnAgregar.Location = new Point(438, 87);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 38);
            btnAgregar.TabIndex = 76;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // DGV_Gastos
            // 
            DGV_Gastos.BackgroundColor = Color.White;
            DGV_Gastos.BorderStyle = BorderStyle.Fixed3D;
            DGV_Gastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Gastos.Location = new Point(45, 240);
            DGV_Gastos.Name = "DGV_Gastos";
            DGV_Gastos.Size = new Size(711, 428);
            DGV_Gastos.TabIndex = 75;
            // 
            // Dt_FechaGasto
            // 
            Dt_FechaGasto.Format = DateTimePickerFormat.Short;
            Dt_FechaGasto.Location = new Point(494, 45);
            Dt_FechaGasto.Name = "Dt_FechaGasto";
            Dt_FechaGasto.Size = new Size(181, 23);
            Dt_FechaGasto.TabIndex = 74;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F);
            label10.Location = new Point(420, 44);
            label10.Name = "label10";
            label10.Size = new Size(68, 22);
            label10.TabIndex = 71;
            label10.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.Location = new Point(31, 161);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 62;
            label5.Text = "Recibido Por";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.Location = new Point(31, 132);
            label4.Name = "label4";
            label4.Size = new Size(145, 22);
            label4.TabIndex = 61;
            label4.Text = "Autorizado Por";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.Location = new Point(31, 103);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 60;
            label3.Text = "Total Gasto";
            // 
            // TB_QuienRecibe
            // 
            TB_QuienRecibe.Location = new Point(233, 160);
            TB_QuienRecibe.Multiline = true;
            TB_QuienRecibe.Name = "TB_QuienRecibe";
            TB_QuienRecibe.Size = new Size(181, 23);
            TB_QuienRecibe.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.Location = new Point(31, 74);
            label2.Name = "label2";
            label2.Size = new Size(196, 22);
            label2.TabIndex = 58;
            label2.Text = "Concepto de Gasto";
            // 
            // TB_ConceptoGastos
            // 
            TB_ConceptoGastos.Location = new Point(233, 73);
            TB_ConceptoGastos.Multiline = true;
            TB_ConceptoGastos.Name = "TB_ConceptoGastos";
            TB_ConceptoGastos.Size = new Size(181, 23);
            TB_ConceptoGastos.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.Location = new Point(31, 45);
            label1.Name = "label1";
            label1.Size = new Size(162, 22);
            label1.TabIndex = 55;
            label1.Text = "Numero de Caja";
            // 
            // CB_QuienAutoriza
            // 
            CB_QuienAutoriza.FormattingEnabled = true;
            CB_QuienAutoriza.Location = new Point(233, 131);
            CB_QuienAutoriza.Name = "CB_QuienAutoriza";
            CB_QuienAutoriza.Size = new Size(181, 23);
            CB_QuienAutoriza.TabIndex = 81;
            // 
            // CB_NumeroCaja
            // 
            CB_NumeroCaja.FormattingEnabled = true;
            CB_NumeroCaja.Location = new Point(233, 44);
            CB_NumeroCaja.Name = "CB_NumeroCaja";
            CB_NumeroCaja.Size = new Size(181, 23);
            CB_NumeroCaja.TabIndex = 80;
            // 
            // CB_TotalGasto
            // 
            CB_TotalGasto.FormattingEnabled = true;
            CB_TotalGasto.Location = new Point(233, 102);
            CB_TotalGasto.Name = "CB_TotalGasto";
            CB_TotalGasto.Size = new Size(181, 23);
            CB_TotalGasto.TabIndex = 82;
            // 
            // FrmGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 714);
            Controls.Add(CB_TotalGasto);
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
            Name = "FrmGastos";
            Text = "Gastos";
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
        private ComboBox CB_TotalGasto;
    }
}