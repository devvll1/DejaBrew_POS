namespace dejabrew_pos.Forms
{
    partial class frmPrintOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintOrder));
            this.rprtReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rprtReceipt
            // 
            this.rprtReceipt.LocalReport.ReportEmbeddedResource = "dejabrew_pos.Reports.Order.rdlc";
            this.rprtReceipt.Location = new System.Drawing.Point(12, 12);
            this.rprtReceipt.Name = "rprtReceipt";
            this.rprtReceipt.Size = new System.Drawing.Size(1088, 562);
            this.rprtReceipt.TabIndex = 0;
            // 
            // frmPrintOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 573);
            this.Controls.Add(this.rprtReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintOrder";
            this.Text = "frmPrintOrder";
            this.Load += new System.EventHandler(this.frmPrintOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtReceipt;
    }
}