namespace Genesis
{
	partial class frmMain
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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Genesis.SplashScreenApp), true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.ctrlCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
			this.ctrlOrders = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// splashScreenManager
			// 
			splashScreenManager.ClosingDelay = 500;
			// 
			// container
			// 
			this.container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.container.Location = new System.Drawing.Point(260, 31);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(582, 470);
			this.container.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
			this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
			this.accordionControl1.Appearance.Item.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 12F);
			this.accordionControl1.Appearance.Item.Hovered.Options.UseBackColor = true;
			this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
			this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
			this.accordionControl1.Appearance.Item.Normal.ForeColor = System.Drawing.Color.Gainsboro;
			this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
			this.accordionControl1.Appearance.Item.Normal.Options.UseForeColor = true;
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlSeparator2});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(260, 470);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ctrlCustomers,
            this.accordionControlSeparator1,
            this.ctrlOrders});
			this.accordionControlElement1.Expanded = true;
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Main";
			// 
			// ctrlCustomers
			// 
			this.ctrlCustomers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
			this.ctrlCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCustomers.ImageOptions.Image")));
			this.ctrlCustomers.Name = "ctrlCustomers";
			this.ctrlCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.ctrlCustomers.Text = "Customers";
			this.ctrlCustomers.Click += new System.EventHandler(this.ctrlCustomers_Click);
			// 
			// accordionControlSeparator1
			// 
			this.accordionControlSeparator1.Name = "accordionControlSeparator1";
			// 
			// ctrlOrders
			// 
			this.ctrlOrders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ctrlOrders.ImageOptions.Image")));
			this.ctrlOrders.Name = "ctrlOrders";
			this.ctrlOrders.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.ctrlOrders.Text = "Orders";
			this.ctrlOrders.Click += new System.EventHandler(this.ctrlOrders_Click);
			// 
			// accordionControlSeparator2
			// 
			this.accordionControlSeparator2.Name = "accordionControlSeparator2";
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1});
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(842, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinDropDownButtonItem1);
			// 
			// skinDropDownButtonItem1
			// 
			this.skinDropDownButtonItem1.Id = 1;
			this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 501);
			this.ControlContainer = this.container;
			this.Controls.Add(this.container);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Name = "frmMain";
			this.NavigationControl = this.accordionControl1;
			this.Text = "Genesis Automation - Demo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlCustomers;
		private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlOrders;
		private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
		private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
		private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
	}
}