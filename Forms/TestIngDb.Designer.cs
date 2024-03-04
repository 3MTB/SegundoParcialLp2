namespace SegundoParcialLp2.Forms
{
	partial class TestIngDb
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
			btnTry = new Button();
			cbOption = new ComboBox();
			btnGuardar = new Button();
			dgRegistro = new DataGridView();
			btnAddCxc = new Button();
			dgCxc = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgRegistro).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgCxc).BeginInit();
			SuspendLayout();
			// 
			// btnTry
			// 
			btnTry.Location = new Point(946, 283);
			btnTry.Name = "btnTry";
			btnTry.Size = new Size(94, 29);
			btnTry.TabIndex = 3;
			btnTry.Text = "Try";
			btnTry.UseVisualStyleBackColor = true;
			btnTry.Click += btnTry_Click;
			// 
			// cbOption
			// 
			cbOption.DropDownStyle = ComboBoxStyle.DropDownList;
			cbOption.FormattingEnabled = true;
			cbOption.Location = new Point(932, 226);
			cbOption.Name = "cbOption";
			cbOption.Size = new Size(151, 28);
			cbOption.TabIndex = 2;
			cbOption.SelectedIndexChanged += cbOption_SelectedIndexChanged;
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(141, 522);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(94, 29);
			btnGuardar.TabIndex = 4;
			btnGuardar.Text = "GUARDAR";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_ClickAsync;
			// 
			// dgRegistro
			// 
			dgRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgRegistro.Dock = DockStyle.Bottom;
			dgRegistro.Location = new Point(0, 557);
			dgRegistro.Name = "dgRegistro";
			dgRegistro.RowHeadersWidth = 51;
			dgRegistro.Size = new Size(1272, 236);
			dgRegistro.TabIndex = 5;
			// 
			// btnAddCxc
			// 
			btnAddCxc.Location = new Point(12, 216);
			btnAddCxc.Name = "btnAddCxc";
			btnAddCxc.Size = new Size(218, 75);
			btnAddCxc.TabIndex = 6;
			btnAddCxc.Text = "btnCxc";
			btnAddCxc.UseVisualStyleBackColor = true;
			btnAddCxc.Click += btnAddCxc_Click;
			// 
			// dgCxc
			// 
			dgCxc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgCxc.Dock = DockStyle.Top;
			dgCxc.Location = new Point(0, 0);
			dgCxc.Name = "dgCxc";
			dgCxc.RowHeadersWidth = 51;
			dgCxc.Size = new Size(1272, 188);
			dgCxc.TabIndex = 7;
			// 
			// TestIngDb
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1272, 793);
			Controls.Add(dgCxc);
			Controls.Add(btnAddCxc);
			Controls.Add(dgRegistro);
			Controls.Add(btnGuardar);
			Controls.Add(btnTry);
			Controls.Add(cbOption);
			Name = "TestIngDb";
			Text = "TestIngDb";
			Load += TestIngDb_Load;
			((System.ComponentModel.ISupportInitialize)dgRegistro).EndInit();
			((System.ComponentModel.ISupportInitialize)dgCxc).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnTry;
		private ComboBox cbOption;
		private Button btnGuardar;
		private DataGridView dgRegistro;
		private Button btnAddCxc;
		private DataGridView dgCxc;
	}
}