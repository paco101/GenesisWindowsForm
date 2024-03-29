﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Genesis
{
	public partial class SplashScreenApp : SplashScreen
	{
		public SplashScreenApp()
		{
			InitializeComponent();
			this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
		}

		#region Overrides

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}

		#endregion

		public enum SplashScreenCommand
		{
		}
	}
}