namespace SegundoParcialLp2.Forms
{
	partial class FrmHome
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			lblDate = new Label();
			tmDate = new System.Windows.Forms.Timer(components);
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 36.2F);
			label1.Location = new Point(351, 75);
			label1.Name = "label1";
			label1.Size = new Size(212, 75);
			label1.TabIndex = 0;
			label1.Text = "Home";
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Century Gothic", 16.2F);
			lblDate.Location = new Point(217, 280);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(43, 34);
			lblDate.TabIndex = 1;
			lblDate.Text = "__";
			// 
			// tmDate
			// 
			tmDate.Enabled = true;
			tmDate.Tick += tmDate_Tick;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Schoolbook", 22F);
			label2.Location = new Point(343, 405);
			label2.Name = "label2";
			label2.Size = new Size(228, 44);
			label2.TabIndex = 2;
			label2.Text = "Creado por: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(219, 509);
			label3.Name = "label3";
			label3.Size = new Size(476, 73);
			label3.TabIndex = 3;
			label3.Text = "Franly and Eury";
			// 
			// FrmHome
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 952);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(lblDate);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FrmHome";
			Text = "Home";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblDate;
		private System.Windows.Forms.Timer tmDate;
		private Label label2;
		private Label label3;
	}
}