using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Genesis.Models;
using DevExpress.XtraSplashScreen;
using System.Data.Entity;

namespace Genesis.Controllers
{
	public partial class HomeUserControl : DevExpress.XtraEditors.XtraUserControl //BaseUserControl //
	{
		//Add Singleton Pattern to ensure one instance of this control will be created
		private static HomeUserControl _instance;

		public static HomeUserControl Instance
		{
			get
			{
				if (_instance == null)
					_instance = new HomeUserControl();
				return _instance;
			}
		}

		public HomeUserControl()
		{
			InitializeComponent(); 
		}
	}
}
