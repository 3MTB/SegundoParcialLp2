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
            btnBorrar.Location = new Point(628, 617);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(128, 38);
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
            btnClear.Location = new Point(608, 162);
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
            btnModificar.Location = new Point(482, 617);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 38);
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
            btnAgregar.Location = new Point(437, 162);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 38);
            btnAgregar.TabIndex = 76;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // DGV_Empleados
            // 
            DGV_Empleados.BackgroundColor = Color.White;
            DGV_Empleados.BorderStyle = BorderStyle.Fixed3D;
            DGV_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Empleados.Location = new Point(45, 255);
            DGV_Empleados.Name = "DGV_Empleados";
            DGV_Empleados.Size = new Size(711, 356);
            DGV_Empleados.TabIndex = 75;
            // 
            // TB_Correo
            // 
            TB_Correo.Location = new Point(559, 96);
            TB_Correo.Multiline = true;
            TB_Correo.Name = "TB_Correo";
            TB_Correo.Size = new Size(181, 23);
            TB_Correo.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F);
            label6.Location = new Point(386, 93);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 64;
            label6.Text = "Sueldo Neto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.Location = new Point(386, 59);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 62;
            label5.Text = "Seguro Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.Location = new Point(45, 147);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 61;
            label4.Text = "IdCxC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.Location = new Point(45, 118);
            label3.Name = "label3";
            label3.Size = new Size(45, 22);
            label3.TabIndex = 60;
            label3.Text = "AFP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.Location = new Point(45, 89);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 58;
            label2.Text = "IdEmpleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.Location = new Point(45, 60);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 55;
            label1.Text = "Tipo de Nomina";
            // 
            // DataTimeEmpleado
            // 
            DataTimeEmpleado.Format = DateTimePickerFormat.Short;
            DataTimeEmpleado.Location = new Point(559, 125);
            DataTimeEmpleado.Name = "DataTimeEmpleado";
            DataTimeEmpleado.Size = new Size(181, 23);
            DataTimeEmpleado.TabIndex = 81;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F);
            label10.Location = new Point(386, 125);
            label10.Name = "label10";
            label10.Size = new Size(68, 22);
            label10.TabIndex = 80;
            label10.Text = "Fecha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(559, 63);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 82;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 118);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 83;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 85;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(199, 89);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(181, 23);
            comboBox2.TabIndex = 86;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(199, 150);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(181, 23);
            comboBox3.TabIndex = 87;
            // 
            // FrmNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 714);
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
            Name = "FrmNomina";
            Text = "FrmNomina";
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