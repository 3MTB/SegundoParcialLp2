namespace SegundoParcialLp2.Forms.UC
{
    partial class UC_Empleados
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TB_Nombre = new TextBox();
            CB_Departamento = new ComboBox();
            TB_Apellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CB_Cargo = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            TB_Direccion = new TextBox();
            TB_Sueldo = new TextBox();
            label10 = new Label();
            TB_Correo = new TextBox();
            MTB_Telefono = new MaskedTextBox();
            MTB_Cedula = new MaskedTextBox();
            DataTimeEmpleado = new DateTimePicker();
            DGV_Empleados = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnClear = new Button();
            btnBorrar = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Empleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.Location = new Point(59, 65);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // TB_Nombre
            // 
            TB_Nombre.Location = new Point(213, 64);
            TB_Nombre.Multiline = true;
            TB_Nombre.Name = "TB_Nombre";
            TB_Nombre.Size = new Size(181, 23);
            TB_Nombre.TabIndex = 1;
            // 
            // CB_Departamento
            // 
            CB_Departamento.FormattingEnabled = true;
            CB_Departamento.Location = new Point(213, 151);
            CB_Departamento.Name = "CB_Departamento";
            CB_Departamento.Size = new Size(181, 23);
            CB_Departamento.TabIndex = 2;
            // 
            // TB_Apellido
            // 
            TB_Apellido.Location = new Point(213, 93);
            TB_Apellido.Multiline = true;
            TB_Apellido.Name = "TB_Apellido";
            TB_Apellido.Size = new Size(181, 23);
            TB_Apellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.Location = new Point(59, 94);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.Location = new Point(59, 123);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 5;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.Location = new Point(59, 152);
            label4.Name = "label4";
            label4.Size = new Size(148, 22);
            label4.TabIndex = 7;
            label4.Text = "Departamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.Location = new Point(59, 181);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 8;
            label5.Text = "Cargo";
            // 
            // CB_Cargo
            // 
            CB_Cargo.FormattingEnabled = true;
            CB_Cargo.Location = new Point(213, 180);
            CB_Cargo.Name = "CB_Cargo";
            CB_Cargo.Size = new Size(181, 23);
            CB_Cargo.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F);
            label6.Location = new Point(59, 215);
            label6.Name = "label6";
            label6.Size = new Size(73, 22);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F);
            label7.Location = new Point(400, 65);
            label7.Name = "label7";
            label7.Size = new Size(87, 22);
            label7.TabIndex = 13;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F);
            label8.Location = new Point(400, 94);
            label8.Name = "label8";
            label8.Size = new Size(96, 22);
            label8.TabIndex = 15;
            label8.Text = "Direccion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F);
            label9.Location = new Point(400, 123);
            label9.Name = "label9";
            label9.Size = new Size(71, 22);
            label9.TabIndex = 17;
            label9.Text = "Sueldo";
            // 
            // TB_Direccion
            // 
            TB_Direccion.Location = new Point(589, 94);
            TB_Direccion.Multiline = true;
            TB_Direccion.Name = "TB_Direccion";
            TB_Direccion.Size = new Size(181, 23);
            TB_Direccion.TabIndex = 16;
            // 
            // TB_Sueldo
            // 
            TB_Sueldo.Location = new Point(589, 123);
            TB_Sueldo.Multiline = true;
            TB_Sueldo.Name = "TB_Sueldo";
            TB_Sueldo.Size = new Size(181, 23);
            TB_Sueldo.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F);
            label10.Location = new Point(400, 152);
            label10.Name = "label10";
            label10.Size = new Size(183, 22);
            label10.TabIndex = 19;
            label10.Text = "Fecha Contratado";
            // 
            // TB_Correo
            // 
            TB_Correo.Location = new Point(213, 215);
            TB_Correo.Multiline = true;
            TB_Correo.Name = "TB_Correo";
            TB_Correo.Size = new Size(181, 23);
            TB_Correo.TabIndex = 12;
            // 
            // MTB_Telefono
            // 
            MTB_Telefono.Location = new Point(589, 65);
            MTB_Telefono.Mask = "000-000-0000";
            MTB_Telefono.Name = "MTB_Telefono";
            MTB_Telefono.Size = new Size(181, 23);
            MTB_Telefono.TabIndex = 21;
            // 
            // MTB_Cedula
            // 
            MTB_Cedula.Location = new Point(213, 122);
            MTB_Cedula.Mask = "000-0000000-0";
            MTB_Cedula.Name = "MTB_Cedula";
            MTB_Cedula.Size = new Size(181, 23);
            MTB_Cedula.TabIndex = 22;
            // 
            // DataTimeEmpleado
            // 
            DataTimeEmpleado.Format = DateTimePickerFormat.Short;
            DataTimeEmpleado.Location = new Point(589, 152);
            DataTimeEmpleado.Name = "DataTimeEmpleado";
            DataTimeEmpleado.Size = new Size(181, 23);
            DataTimeEmpleado.TabIndex = 23;
            // 
            // DGV_Empleados
            // 
            DGV_Empleados.BackgroundColor = Color.White;
            DGV_Empleados.BorderStyle = BorderStyle.Fixed3D;
            DGV_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Empleados.Location = new Point(59, 260);
            DGV_Empleados.Name = "DGV_Empleados";
            DGV_Empleados.Size = new Size(711, 356);
            DGV_Empleados.TabIndex = 24;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Teal;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(418, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 38);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Teal;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(496, 622);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 38);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Aqua;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(589, 199);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 38);
            btnClear.TabIndex = 27;
            btnClear.Text = "Limpiar Campos";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.DarkRed;
            btnBorrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(642, 622);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(128, 38);
            btnBorrar.TabIndex = 28;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(345, 17);
            label11.Name = "label11";
            label11.Size = new Size(119, 23);
            label11.TabIndex = 29;
            label11.Text = "EMPLEADOS";
            // 
            // UC_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label11);
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
            Name = "UC_Empleados";
            Size = new Size(836, 693);
            Load += UC_Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_Nombre;
        private ComboBox CB_Departamento;
        private TextBox TB_Apellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CB_Cargo;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox TB_Direccion;
        private TextBox TB_Sueldo;
        private Label label10;
        private TextBox TB_Correo;
        private MaskedTextBox MTB_Telefono;
        private MaskedTextBox MTB_Cedula;
        private DateTimePicker DataTimeEmpleado;
        private DataGridView DGV_Empleados;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnClear;
        private Button btnBorrar;
        private Label label11;
    }
}
