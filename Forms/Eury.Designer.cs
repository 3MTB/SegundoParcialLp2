namespace SegundoParcialLp2.Forms
{
	partial class Eury
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
			cbOptions = new ComboBox();
			btnTry = new Button();
			SuspendLayout();
			// 
			// cbOptions
			// 
			cbOptions.DropDownStyle = ComboBoxStyle.DropDownList;
			cbOptions.FormattingEnabled = true;
			cbOptions.Location = new Point(40, 103);
			cbOptions.Name = "cbOptions";
			cbOptions.Size = new Size(151, 28);
			cbOptions.TabIndex = 0;
			// 
			// btnTry
			// 
			btnTry.Location = new Point(161, 213);
			btnTry.Name = "btnTry";
			btnTry.Size = new Size(94, 29);
			btnTry.TabIndex = 1;
			btnTry.Text = "TRY CONNECT";
			btnTry.UseVisualStyleBackColor = true;
			btnTry.Click += btnTry_Click;
			// 
			// Eury
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnTry);
			Controls.Add(cbOptions);
			Name = "Eury";
			Text = "Eury";
			Load += Eury_Load;
			ResumeLayout(false);
		}

		#endregion

		private ComboBox cbOptions;
		private Button btnTry;
	}
}