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
	public partial class CustomerUserControl : DevExpress.XtraEditors.XtraUserControl //BaseUserControl //
	{
		protected readonly ModelOrdes context = new ModelOrdes();
		private Customer _customer;

		//Add Singleton Pattern to ensure one instance of this control will be created
		private static CustomerUserControl _instance;

		public static CustomerUserControl Instance
		{
			get
			{
				if (_instance == null)
					_instance = new CustomerUserControl();
				return _instance;
			}
		}

		public CustomerUserControl()
		{
			InitializeComponent(); 
		}



		private void CustomerUserControl_Load(object sender, EventArgs e)
		{
			//LoadCustomer();
		}

		public void LoadCustomerScreen(string customerId = "")
		{
			//Open Wait Form
			SplashScreenManager.ShowForm(this.ParentForm, typeof(WaitingForm), true, true, false);
			try
			{
				LoadCustomerData(customerId);
				textFirstName.Text = _customer.FirstName;
				textLastName.Text = _customer.LastName;
			}
			finally
			{
				//Close Wait Form
				SplashScreenManager.CloseForm(false);
			}
		}

		public Customer LoadCustomerData(string customerId = "")
		{
			_customer = new Customer();
			if (!string.IsNullOrEmpty(customerId))
				_customer = context.Customers.Where(c => c.Id.ToString() == customerId).FirstOrDefault();
			return _customer;
		}

		private async Task<bool> SaveCustomer()
		{
			bool updated = false;
			//Open Wait Form
			SplashScreenManager.ShowForm(this.ParentForm, typeof(WaitingForm), true, true, false);
			try
			{
				_customer.FirstName = textFirstName.Text.Trim();
				_customer.LastName = textLastName.Text.Trim();
				updated = await SaveCustomerData(_customer);
			}
			finally
			{
				//Close Wait Form
				SplashScreenManager.CloseForm(false);
			}
			return updated;
		}


		public async Task<bool> SaveCustomerData(Customer cust)
		{
			var checkIfNameExists = await context.Customers.Where(c => c.FirstName == cust.FirstName && c.LastName == cust.LastName && c.Id != _customer.Id).SingleOrDefaultAsync();
			if (checkIfNameExists == null)
			{
				//update customer object
				context.Entry(_customer).State = System.Data.Entity.EntityState.Modified;
				if (context.SaveChanges() > 0)
				{
					return true;
				}
			}
			return false;
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show("Do you want to change the current record?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			if (await SaveCustomer())
			{
				OrderUserControl.Instance.LoadOrders(false);
				this.Hide();
			}
			else
			{
				XtraMessageBoxArgs args = new XtraMessageBoxArgs();
				args.AutoCloseOptions.Delay = 3000;
				args.Caption = "Info";
				args.Text = "Customer name duplicated.";
				args.Buttons = new DialogResult[] { DialogResult.Cancel };
				XtraMessageBox.Show(args).ToString();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
