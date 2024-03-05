namespace SegundoParcialLp2.Forms
{
    partial class DashBoard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
			panel1 = new Panel();
			btnGastos = new Button();
			btnCxC = new Button();
			btnNomina = new Button();
			btnEmpleados = new Button();
			btnInicio = new Button();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			LbT_NameVtn = new Label();
			label1 = new Label();
			pbClose = new PictureBox();
			panelDesk = new Panel();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkCyan;
			panel1.Controls.Add(btnGastos);
			panel1.Controls.Add(btnCxC);
			panel1.Controls.Add(btnNomina);
			panel1.Controls.Add(btnEmpleados);
			panel1.Controls.Add(btnInicio);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(208, 873);
			panel1.TabIndex = 0;
			// 
			// btnGastos
			// 
			btnGastos.FlatAppearance.BorderSize = 2;
			btnGastos.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
			btnGastos.FlatStyle = FlatStyle.Flat;
			btnGastos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnGastos.ForeColor = Color.White;
			btnGastos.Image = (Image)resources.GetObject("btnGastos.Image");
			btnGastos.ImageAlign = ContentAlignment.TopCenter;
			btnGastos.Location = new Point(31, 716);
			btnGastos.Name = "btnGastos";
			btnGastos.Size = new Size(127, 110);
			btnGastos.TabIndex = 6;
			btnGastos.Text = "Gastos";
			btnGastos.TextAlign = ContentAlignment.BottomCenter;
			btnGastos.UseVisualStyleBackColor = true;
			btnGastos.Click += btnGastos_Click;
			// 
			// btnCxC
			// 
			btnCxC.FlatAppearance.BorderSize = 2;
			btnCxC.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
			btnCxC.FlatStyle = FlatStyle.Flat;
			btnCxC.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCxC.ForeColor = Color.White;
			btnCxC.Image = (Image)resources.GetObject("btnCxC.Image");
			btnCxC.ImageAlign = ContentAlignment.TopCenter;
			btnCxC.Location = new Point(31, 577);
			btnCxC.Name = "btnCxC";
			btnCxC.Size = new Size(127, 110);
			btnCxC.TabIndex = 5;
			btnCxC.Text = "CxC";
			btnCxC.TextAlign = ContentAlignment.BottomCenter;
			btnCxC.UseVisualStyleBackColor = true;
			btnCxC.Click += btnCxC_Click;
			// 
			// btnNomina
			// 
			btnNomina.FlatAppearance.BorderSize = 2;
			btnNomina.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
			btnNomina.FlatStyle = FlatStyle.Flat;
			btnNomina.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNomina.ForeColor = Color.White;
			btnNomina.Image = (Image)resources.GetObject("btnNomina.Image");
			btnNomina.ImageAlign = ContentAlignment.TopCenter;
			btnNomina.Location = new Point(31, 434);
			btnNomina.Name = "btnNomina";
			btnNomina.Size = new Size(127, 110);
			btnNomina.TabIndex = 4;
			btnNomina.Text = "Nomina";
			btnNomina.TextAlign = ContentAlignment.BottomCenter;
			btnNomina.UseVisualStyleBackColor = true;
			btnNomina.Click += btnNomina_Click;
			// 
			// btnEmpleados
			// 
			btnEmpleados.FlatAppearance.BorderSize = 2;
			btnEmpleados.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
			btnEmpleados.FlatStyle = FlatStyle.Flat;
			btnEmpleados.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnEmpleados.ForeColor = Color.White;
			btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
			btnEmpleados.ImageAlign = ContentAlignment.TopCenter;
			btnEmpleados.Location = new Point(31, 290);
			btnEmpleados.Name = "btnEmpleados";
			btnEmpleados.Size = new Size(127, 110);
			btnEmpleados.TabIndex = 3;
			btnEmpleados.Text = "Empleados";
			btnEmpleados.TextAlign = ContentAlignment.BottomCenter;
			btnEmpleados.UseVisualStyleBackColor = true;
			btnEmpleados.Click += btnEmpleados_Click;
			// 
			// btnInicio
			// 
			btnInicio.FlatAppearance.BorderSize = 2;
			btnInicio.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
			btnInicio.FlatStyle = FlatStyle.Flat;
			btnInicio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnInicio.ForeColor = Color.White;
			btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
			btnInicio.ImageAlign = ContentAlignment.TopCenter;
			btnInicio.Location = new Point(31, 148);
			btnInicio.Name = "btnInicio";
			btnInicio.Size = new Size(127, 110);
			btnInicio.TabIndex = 2;
			btnInicio.Text = "Inicio";
			btnInicio.TextAlign = ContentAlignment.BottomCenter;
			btnInicio.UseVisualStyleBackColor = true;
			btnInicio.Click += btnInicio_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.DarkCyan;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(42, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(107, 99);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Right;
			panel2.BackColor = Color.Teal;
			panel2.Controls.Add(LbT_NameVtn);
			panel2.Location = new Point(214, 70);
			panel2.Name = "panel2";
			panel2.Size = new Size(1066, 92);
			panel2.TabIndex = 1;
			// 
			// LbT_NameVtn
			// 
			LbT_NameVtn.AutoSize = true;
			LbT_NameVtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LbT_NameVtn.ForeColor = Color.White;
			LbT_NameVtn.Location = new Point(466, 34);
			LbT_NameVtn.Name = "LbT_NameVtn";
			LbT_NameVtn.Size = new Size(84, 32);
			LbT_NameVtn.TabIndex = 8;
			LbT_NameVtn.Text = "Inicio";
			LbT_NameVtn.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(527, 22);
			label1.Name = "label1";
			label1.Size = new Size(563, 37);
			label1.TabIndex = 2;
			label1.Text = "Ambar SRL Sistema De Administracion";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbClose
			// 
			pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pbClose.Image = (Image)resources.GetObject("pbClose.Image");
			pbClose.Location = new Point(1240, 2);
			pbClose.Name = "pbClose";
			pbClose.Size = new Size(40, 35);
			pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
			pbClose.TabIndex = 8;
			pbClose.TabStop = false;
			pbClose.Click += pbClose_Click;
			// 
			// panelDesk
			// 
			panelDesk.Location = new Point(343, 168);
			panelDesk.Name = "panelDesk";
			panelDesk.Size = new Size(836, 693);
			panelDesk.TabIndex = 9;
			// 
			// DashBoard
			// 
			AutoScaleDimensions = new SizeF(11F, 22F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1286, 873);
			Controls.Add(panelDesk);
			Controls.Add(pbClose);
			Controls.Add(label1);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4);
			Name = "DashBoard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Ambar SRL";
			Load += DashBoard_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Button btnEmpleados;
        private Button btnNomina;
        private Button btnCxC;
        private Button btnGastos;
        private Label label1;
        private PictureBox pbClose;
        private Panel panelDesk;
        private Label LbT_NameVtn;
    }
}