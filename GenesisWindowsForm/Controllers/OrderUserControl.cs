using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Genesis.Helpers;
using Genesis.Models;
//using Genesis.DataModel;

namespace Genesis.Controllers
{
	public partial class OrderUserControl : DevExpress.XtraEditors.XtraUserControl //BaseUserControl //
	{
		//Add Singleton Pattern to ensure one instance of this control will be created
		private static OrderUserControl _instance;

		public static OrderUserControl Instance
		{
			get
			{
				if (_instance == null)
					_instance = new OrderUserControl();
				return _instance;
			}
		}

		public OrderUserControl()
		{
			InitializeComponent();
		}

		private void OrderUserControl_Load(object sender, EventArgs e)
		{			
			//Open Wait Form
			SplashScreenManager.ShowForm(this.ParentForm, typeof(WaitingForm), true, true, false);
			try
			{
				LoadOrders();
			}
			finally
			{
				//Close Wait Form
				SplashScreenManager.CloseForm(false);
			}
		}

		public void LoadOrders(bool showLoader = true, int pageIndex = 0)
		{
			//Load List Orders from Orders table including Customers
			ModelOrdes context = new ModelOrdes();
			List<Order> listOrders = new List<Order>();
			int pageSize = 10;
			listOrders = context.Orders.Include("Customer").OrderBy(o => o.Id).ToPagedList(pageIndex +1, pageSize);
			gOrders.DataSource = listOrders;
			gvOrders.RefreshData();
		}

		private void gvOrders_DoubleClick_1(object sender, EventArgs e)
		{
			int visibleIndex = gvOrders.FocusedRowHandle;
			string customerId = gvOrders.GetRowCellValue(visibleIndex, "CustomerId").ToString();
			frmMain f = (frmMain)this.Parent.FindForm();
			f.ShowController(CustomerUserControl.Instance);
			CustomerUserControl.Instance.LoadCustomerScreen(customerId);
		}
	}
}
