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
			SuspendLayout();
			// 
			// btnTry
			// 
			btnTry.Location = new Point(330, 279);
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
			cbOption.Location = new Point(325, 142);
			cbOption.Name = "cbOption";
			cbOption.Size = new Size(151, 28);
			cbOption.TabIndex = 2;
			cbOption.SelectedIndexChanged += cbOption_SelectedIndexChanged;
			// 
			// TestIngDb
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnTry);
			Controls.Add(cbOption);
			Name = "TestIngDb";
			Text = "TestIngDb";
			Load += TestIngDb_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnTry;
		private ComboBox cbOption;
	}
}