namespace dejabrew_pos.Forms
{
    partial class frmSale
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.dtOrdersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrders = new dejabrew_pos.Datasets.dsOrders();
            this.rprtSaleOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOrdersBindingSource1
            // 
            this.dtOrdersBindingSource1.DataMember = "dtOrders";
            this.dtOrdersBindingSource1.DataSource = this.dsOrders;
            // 
            // dsOrders
            // 
            this.dsOrders.DataSetName = "dsOrders";
            this.dsOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rprtSaleOrder
            // 
            reportDataSource1.Name = "dsOrders";
            reportDataSource1.Value = this.dtOrdersBindingSource1;
            this.rprtSaleOrder.LocalReport.DataSources.Add(reportDataSource1);
            this.rprtSaleOrder.LocalReport.ReportEmbeddedResource = "dejabrew_pos.Reports.Sale.rdlc";
            this.rprtSaleOrder.Location = new System.Drawing.Point(-3, -2);
            this.rprtSaleOrder.Name = "rprtSaleOrder";
            this.rprtSaleOrder.Size = new System.Drawing.Size(1054, 600);
            this.rprtSaleOrder.TabIndex = 0;
            // 
            // dtOrdersBindingSource
            // 
            this.dtOrdersBindingSource.DataMember = "dtOrders";
            this.dtOrdersBindingSource.DataSource = this.dsOrders;
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Bisque;
            this.btnHome.BorderRadius = 20;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnHome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(944, 610);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(96, 43);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 665);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rprtSaleOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtSaleOrder;
        private Datasets.dsOrders dsOrders;
        private System.Windows.Forms.BindingSource dtOrdersBindingSource;
        private System.Windows.Forms.BindingSource dtOrdersBindingSource1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}