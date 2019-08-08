namespace Genesis.Controllers
{
	partial class OrderUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gOrders = new DevExpress.XtraGrid.GridControl();
			this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			((System.ComponentModel.ISupportInitialize)(this.gOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// gOrders
			// 
			this.gOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gOrders.Location = new System.Drawing.Point(0, 0);
			this.gOrders.MainView = this.gvOrders;
			this.gOrders.Name = "gOrders";
			this.gOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
			this.gOrders.Size = new System.Drawing.Size(605, 388);
			this.gOrders.TabIndex = 0;
			this.gOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders});
			this.gOrders.DoubleClick += new System.EventHandler(this.gvOrders_DoubleClick_1);
			// 
			// gvOrders
			// 
			this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
			this.gvOrders.GridControl = this.gOrders;
			this.gvOrders.Name = "gvOrders";
			this.gvOrders.OptionsBehavior.SmartVertScrollBar = false;
			this.gvOrders.OptionsFind.AlwaysVisible = true;
			this.gvOrders.OptionsView.ShowFooter = true;
			this.gvOrders.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gvOrders.DoubleClick += new System.EventHandler(this.gvOrders_DoubleClick_1);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Reference Number";
			this.gridColumn1.FieldName = "ReferenceNumber";
			this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.AllowEdit = false;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 129;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Order Value (USD)";
			this.gridColumn2.DisplayFormat.FormatString = "0.00";
			this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumn2.FieldName = "OrderValue";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.OptionsColumn.AllowEdit = false;
			this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderValue", "Total (USD) = {0:0.00}")});
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 167;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Order Date";
			this.gridColumn3.DisplayFormat.FormatString = "dd-MMM-yyyy";
			this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.gridColumn3.FieldName = "OrderDate";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.AllowEdit = false;
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 142;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Full Name";
			this.gridColumn4.FieldName = "FullName";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.AllowEdit = false;
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			this.gridColumn4.Width = 144;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "CustomerId";
			this.gridColumn5.FieldName = "CustomerId";
			this.gridColumn5.Name = "gridColumn5";
			// 
			// repositoryItemButtonEdit1
			// 
			this.repositoryItemButtonEdit1.AutoHeight = false;
			this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
			// 
			// OrderUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gOrders);
			this.Name = "OrderUserControl";
			this.Size = new System.Drawing.Size(605, 388);
			this.Load += new System.EventHandler(this.OrderUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.gOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gOrders;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
		private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
	}
}
