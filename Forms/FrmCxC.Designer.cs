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
            DGV_Gastos = new DataGridView();
            Dt_FechaPrestamo = new DateTimePicker();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            CB_TotalCxC = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Gastos).BeginInit();
            SuspendLayout();
            // 
            // CB_IdEmpleado
            // 
            CB_IdEmpleado.FormattingEnabled = true;
            CB_IdEmpleado.Location = new Point(251, 69);
            CB_IdEmpleado.Name = "CB_IdEmpleado";
            CB_IdEmpleado.Size = new Size(181, 23);
            CB_IdEmpleado.TabIndex = 97;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.DarkRed;
            btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(610, 113);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(132, 38);
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
            btnClear.Location = new Point(610, 69);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 38);
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
            btnModificar.Location = new Point(461, 114);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 38);
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
            btnAgregar.Location = new Point(461, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 38);
            btnAgregar.TabIndex = 93;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // DGV_Gastos
            // 
            DGV_Gastos.BackgroundColor = Color.White;
            DGV_Gastos.BorderStyle = BorderStyle.Fixed3D;
            DGV_Gastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Gastos.Location = new Point(42, 190);
            DGV_Gastos.Name = "DGV_Gastos";
            DGV_Gastos.Size = new Size(711, 428);
            DGV_Gastos.TabIndex = 92;
            // 
            // Dt_FechaPrestamo
            // 
            Dt_FechaPrestamo.Format = DateTimePickerFormat.Short;
            Dt_FechaPrestamo.Location = new Point(251, 127);
            Dt_FechaPrestamo.Name = "Dt_FechaPrestamo";
            Dt_FechaPrestamo.Size = new Size(181, 23);
            Dt_FechaPrestamo.TabIndex = 91;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F);
            label10.Location = new Point(49, 128);
            label10.Name = "label10";
            label10.Size = new Size(188, 22);
            label10.TabIndex = 90;
            label10.Text = "Fecha de Prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.Location = new Point(49, 99);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 85;
            label2.Text = "Total CxC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.Location = new Point(49, 70);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 83;
            label1.Text = "Id Empleado";
            // 
            // CB_TotalCxC
            // 
            CB_TotalCxC.FormattingEnabled = true;
            CB_TotalCxC.Location = new Point(251, 98);
            CB_TotalCxC.Name = "CB_TotalCxC";
            CB_TotalCxC.Size = new Size(181, 23);
            CB_TotalCxC.TabIndex = 98;
            // 
            // FrmCxC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 714);
            Controls.Add(CB_TotalCxC);
            Controls.Add(CB_IdEmpleado);
            Controls.Add(btnBorrar);
            Controls.Add(btnClear);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(DGV_Gastos);
            Controls.Add(Dt_FechaPrestamo);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCxC";
            Text = "CxC";
            ((System.ComponentModel.ISupportInitialize)DGV_Gastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CB_IdEmpleado;
        private Button btnBorrar;
        private Button btnClear;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView DGV_Gastos;
        private DateTimePicker Dt_FechaPrestamo;
        private Label label10;
        private Label label2;
        private Label label1;
        private ComboBox CB_TotalCxC;
    }
}