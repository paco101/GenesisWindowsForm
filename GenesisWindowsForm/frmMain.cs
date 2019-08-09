using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Genesis.Controllers;

namespace Genesis
{
	public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{

		private static frmMain _instance;

		public static frmMain Instance
		{
			get
			{
				if (_instance == null)
					_instance = new frmMain();
				return _instance;
			}
		}

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			ShowController(HomeUserControl.Instance);
		}

		private void ctrlCustomers_Click(object sender, EventArgs e)
		{
			ShowController(CustomerUserControl.Instance);
		}

		private void ctrlOrders_Click(object sender, EventArgs e)
		{
			ShowController(OrderUserControl.Instance);
		}

		public void ShowController(DevExpress.XtraEditors.XtraUserControl control)
		{
			if (!container.Controls.Contains(control))
			{ 
				container.Controls.Add(control);
				control.Dock = DockStyle.Fill;
			}
			control.BringToFront();
			control.Show();
		}
	}
}
