namespace Accounting.App
{
    partial class Form1
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonstrip = new System.Windows.Forms.StatusStrip();
            this.labelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecieve = new System.Windows.Forms.ToolStripButton();
            this.btnReportPay = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.buttonstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.toolStripSeparator1,
            this.btnNewAccounting,
            this.toolStripSeparator3,
            this.btnReportRecieve,
            this.btnReportPay,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(145, 458);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // buttonstrip
            // 
            this.buttonstrip.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonstrip.AllowMerge = false;
            this.buttonstrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonstrip.AutoSize = false;
            this.buttonstrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonstrip.Dock = System.Windows.Forms.DockStyle.None;
            this.buttonstrip.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buttonstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDate,
            this.LabelTime});
            this.buttonstrip.Location = new System.Drawing.Point(0, 412);
            this.buttonstrip.Name = "buttonstrip";
            this.buttonstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.buttonstrip.Size = new System.Drawing.Size(424, 46);
            this.buttonstrip.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(187, 40);
            this.labelDate.Text = "toolStripStatusLabel1";
            // 
            // LabelTime
            // 
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(187, 40);
            this.LabelTime.Text = "toolStripStatusLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Accounting.App.Properties.Resources.Background_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(148, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 294);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(142, 64);
            this.btnCustomer.Text = "Seller";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(142, 64);
            this.btnNewAccounting.Text = "New Transaction";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnReportRecieve
            // 
            this.btnReportRecieve.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnReportRecieve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRecieve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecieve.Name = "btnReportRecieve";
            this.btnReportRecieve.Size = new System.Drawing.Size(142, 64);
            this.btnReportRecieve.Text = "Report Recieve";
            this.btnReportRecieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRecieve.Click += new System.EventHandler(this.btnReportRecieve_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(142, 64);
            this.btnReportPay.Text = "Report Pay";
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(424, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonstrip);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.buttonstrip.ResumeLayout(false);
            this.buttonstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReportPay;
        private System.Windows.Forms.ToolStripButton btnReportRecieve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip buttonstrip;
        private System.Windows.Forms.ToolStripStatusLabel LabelTime;
        private System.Windows.Forms.ToolStripStatusLabel labelDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

