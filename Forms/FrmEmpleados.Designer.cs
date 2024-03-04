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
            btnBorrar = new Button();
            btnClear = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            DGV_Empleados = new DataGridView();
            DataTimeEmpleado = new DateTimePicker();
            MTB_Cedula = new MaskedTextBox();
            MTB_Telefono = new MaskedTextBox();
            label10 = new Label();
            TB_Sueldo = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)DGV_Empleados).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.DarkRed;
            btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(631, 610);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(128, 38);
            btnBorrar.TabIndex = 54;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(578, 187);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 38);
            btnClear.TabIndex = 53;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Teal;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(485, 610);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 38);
            btnModificar.TabIndex = 52;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Teal;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(407, 187);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 38);
            btnAgregar.TabIndex = 51;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // DGV_Empleados
            // 
            DGV_Empleados.BackgroundColor = Color.White;
            DGV_Empleados.BorderStyle = BorderStyle.Fixed3D;
            DGV_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Empleados.Location = new Point(48, 248);
            DGV_Empleados.Name = "DGV_Empleados";
            DGV_Empleados.Size = new Size(711, 356);
            DGV_Empleados.TabIndex = 50;
            // 
            // DataTimeEmpleado
            // 
            DataTimeEmpleado.Format = DateTimePickerFormat.Short;
            DataTimeEmpleado.Location = new Point(578, 140);
            DataTimeEmpleado.Name = "DataTimeEmpleado";
            DataTimeEmpleado.Size = new Size(181, 23);
            DataTimeEmpleado.TabIndex = 49;
            // 
            // MTB_Cedula
            // 
            MTB_Cedula.Location = new Point(202, 110);
            MTB_Cedula.Mask = "000-0000000-0";
            MTB_Cedula.Name = "MTB_Cedula";
            MTB_Cedula.Size = new Size(181, 23);
            MTB_Cedula.TabIndex = 48;
            // 
            // MTB_Telefono
            // 
            MTB_Telefono.Location = new Point(578, 53);
            MTB_Telefono.Mask = "000-000-0000";
            MTB_Telefono.Name = "MTB_Telefono";
            MTB_Telefono.Size = new Size(181, 23);
            MTB_Telefono.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F);
            label10.Location = new Point(389, 140);
            label10.Name = "label10";
            label10.Size = new Size(183, 22);
            label10.TabIndex = 46;
            label10.Text = "Fecha Contratado";
            // 
            // TB_Sueldo
            // 
            TB_Sueldo.Location = new Point(578, 111);
            TB_Sueldo.Multiline = true;
            TB_Sueldo.Name = "TB_Sueldo";
            TB_Sueldo.Size = new Size(181, 23);
            TB_Sueldo.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F);
            label9.Location = new Point(389, 111);
            label9.Name = "label9";
            label9.Size = new Size(71, 22);
            label9.TabIndex = 44;
            label9.Text = "Sueldo";
            // 
            // TB_Direccion
            // 
            TB_Direccion.Location = new Point(578, 82);
            TB_Direccion.Multiline = true;
            TB_Direccion.Name = "TB_Direccion";
            TB_Direccion.Size = new Size(181, 23);
            TB_Direccion.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F);
            label8.Location = new Point(389, 82);
            label8.Name = "label8";
            label8.Size = new Size(96, 22);
            label8.TabIndex = 42;
            label8.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F);
            label7.Location = new Point(389, 53);
            label7.Name = "label7";
            label7.Size = new Size(87, 22);
            label7.TabIndex = 41;
            label7.Text = "Telefono";
            // 
            // TB_Correo
            // 
            TB_Correo.Location = new Point(202, 203);
            TB_Correo.Multiline = true;
            TB_Correo.Name = "TB_Correo";
            TB_Correo.Size = new Size(181, 23);
            TB_Correo.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F);
            label6.Location = new Point(48, 203);
            label6.Name = "label6";
            label6.Size = new Size(73, 22);
            label6.TabIndex = 39;
            label6.Text = "Correo";
            // 
            // CB_Cargo
            // 
            CB_Cargo.FormattingEnabled = true;
            CB_Cargo.Location = new Point(202, 168);
            CB_Cargo.Name = "CB_Cargo";
            CB_Cargo.Size = new Size(181, 23);
            CB_Cargo.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.Location = new Point(48, 169);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 37;
            label5.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.Location = new Point(48, 140);
            label4.Name = "label4";
            label4.Size = new Size(148, 22);
            label4.TabIndex = 36;
            label4.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.Location = new Point(48, 111);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 35;
            label3.Text = "Cedula";
            // 
            // TB_Apellido
            // 
            TB_Apellido.Location = new Point(202, 81);
            TB_Apellido.Multiline = true;
            TB_Apellido.Name = "TB_Apellido";
            TB_Apellido.Size = new Size(181, 23);
            TB_Apellido.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.Location = new Point(48, 82);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 33;
            label2.Text = "Apellido";
            // 
            // CB_Departamento
            // 
            CB_Departamento.FormattingEnabled = true;
            CB_Departamento.Location = new Point(202, 139);
            CB_Departamento.Name = "CB_Departamento";
            CB_Departamento.Size = new Size(181, 23);
            CB_Departamento.TabIndex = 32;
            // 
            // TB_Nombre
            // 
            TB_Nombre.Location = new Point(202, 52);
            TB_Nombre.Multiline = true;
            TB_Nombre.Name = "TB_Nombre";
            TB_Nombre.Size = new Size(181, 23);
            TB_Nombre.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.Location = new Point(48, 53);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 714);
            Controls.Add(btnBorrar);
            Controls.Add(btnClear);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(DGV_Empleados);
            Controls.Add(DataTimeEmpleado);
            Controls.Add(MTB_Cedula);
            Controls.Add(MTB_Telefono);
            Controls.Add(label10);
            Controls.Add(TB_Sueldo);
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
            Name = "FrmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
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
        private DateTimePicker DataTimeEmpleado;
        private MaskedTextBox MTB_Cedula;
        private MaskedTextBox MTB_Telefono;
        private Label label10;
        private TextBox TB_Sueldo;
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
    }
}