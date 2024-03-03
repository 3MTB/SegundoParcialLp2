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
			((System.ComponentModel.ISupportInitialize)dgRegistro).BeginInit();
			SuspendLayout();
			// 
			// btnTry
			// 
			btnTry.Location = new Point(963, 191);
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
			cbOption.Location = new Point(936, 126);
			cbOption.Name = "cbOption";
			cbOption.Size = new Size(151, 28);
			cbOption.TabIndex = 2;
			cbOption.SelectedIndexChanged += cbOption_SelectedIndexChanged;
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(47, 427);
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
			// TestIngDb
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1272, 793);
			Controls.Add(dgRegistro);
			Controls.Add(btnGuardar);
			Controls.Add(btnTry);
			Controls.Add(cbOption);
			Name = "TestIngDb";
			Text = "TestIngDb";
			Load += TestIngDb_Load;
			((System.ComponentModel.ISupportInitialize)dgRegistro).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnTry;
		private ComboBox cbOption;
		private Button btnGuardar;
		private DataGridView dgRegistro;
	}
}