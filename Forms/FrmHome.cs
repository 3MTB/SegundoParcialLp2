﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialLp2.Forms
{
	public partial class FrmHome : Form
	{
		public FrmHome()
		{
			InitializeComponent();
		}

		private void tmDate_Tick(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToString();
		}
	}
}
