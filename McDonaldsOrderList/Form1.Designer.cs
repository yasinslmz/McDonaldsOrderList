namespace McDonaldsOrderList
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.preparingPanel = new System.Windows.Forms.Panel();
            this.readyPanel = new System.Windows.Forms.Panel();
            this.preparingLabel = new System.Windows.Forms.Label();
            this.readyLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.preparingOrdersPanel = new System.Windows.Forms.Panel();
            this.orderReadyPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.preparingPanel.SuspendLayout();
            this.readyPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.headerPanel.Controls.Add(this.readyPanel);
            this.headerPanel.Controls.Add(this.preparingPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1400, 100);
            this.headerPanel.TabIndex = 0;
            // 
            // preparingPanel
            // 
            this.preparingPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preparingPanel.Controls.Add(this.preparingLabel);
            this.preparingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.preparingPanel.Location = new System.Drawing.Point(694, 0);
            this.preparingPanel.Name = "preparingPanel";
            this.preparingPanel.Size = new System.Drawing.Size(706, 100);
            this.preparingPanel.TabIndex = 0;
            // 
            // readyPanel
            // 
            this.readyPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.readyPanel.Controls.Add(this.readyLabel);
            this.readyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.readyPanel.Location = new System.Drawing.Point(0, 0);
            this.readyPanel.Name = "readyPanel";
            this.readyPanel.Size = new System.Drawing.Size(688, 100);
            this.readyPanel.TabIndex = 1;
            // 
            // preparingLabel
            // 
            this.preparingLabel.AutoSize = true;
            this.preparingLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preparingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.preparingLabel.Location = new System.Drawing.Point(200, 23);
            this.preparingLabel.Name = "preparingLabel";
            this.preparingLabel.Size = new System.Drawing.Size(346, 45);
            this.preparingLabel.TabIndex = 0;
            this.preparingLabel.Text = "Sipariş Hazırlanıyor";
            // 
            // readyLabel
            // 
            this.readyLabel.AutoSize = true;
            this.readyLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.readyLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readyLabel.Location = new System.Drawing.Point(211, 23);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(232, 45);
            this.readyLabel.TabIndex = 1;
            this.readyLabel.Text = "Sipariş Hazır";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainPanel.Controls.Add(this.orderReadyPanel);
            this.mainPanel.Controls.Add(this.preparingOrdersPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1400, 545);
            this.mainPanel.TabIndex = 1;
            // 
            // preparingOrdersPanel
            // 
            this.preparingOrdersPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.preparingOrdersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.preparingOrdersPanel.Location = new System.Drawing.Point(694, 0);
            this.preparingOrdersPanel.Name = "preparingOrdersPanel";
            this.preparingOrdersPanel.Size = new System.Drawing.Size(706, 545);
            this.preparingOrdersPanel.TabIndex = 0;
            // 
            // orderReadyPanel
            // 
            this.orderReadyPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderReadyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderReadyPanel.Location = new System.Drawing.Point(0, 0);
            this.orderReadyPanel.Name = "orderReadyPanel";
            this.orderReadyPanel.Size = new System.Drawing.Size(688, 545);
            this.orderReadyPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1400, 645);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.headerPanel.ResumeLayout(false);
            this.preparingPanel.ResumeLayout(false);
            this.preparingPanel.PerformLayout();
            this.readyPanel.ResumeLayout(false);
            this.readyPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel readyPanel;
        private System.Windows.Forms.Panel preparingPanel;
        private System.Windows.Forms.Label preparingLabel;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel orderReadyPanel;
        private System.Windows.Forms.Panel preparingOrdersPanel;
    }
}

