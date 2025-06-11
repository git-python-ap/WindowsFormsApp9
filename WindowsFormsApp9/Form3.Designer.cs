namespace WindowsFormsApp9
{
    partial class RequestRefundForm
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
            this.listBoxRefunds = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackToTopUpPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRefunds
            // 
            this.listBoxRefunds.FormattingEnabled = true;
            this.listBoxRefunds.Location = new System.Drawing.Point(148, 95);
            this.listBoxRefunds.Name = "listBoxRefunds";
            this.listBoxRefunds.Size = new System.Drawing.Size(218, 82);
            this.listBoxRefunds.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(166, 191);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Appove";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(270, 191);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(75, 23);
            this.btnRefund.TabIndex = 2;
            this.btnRefund.Text = "Reject";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top-Up Balance";
            // 
            // btnBackToTopUpPage
            // 
            this.btnBackToTopUpPage.Location = new System.Drawing.Point(429, 12);
            this.btnBackToTopUpPage.Name = "btnBackToTopUpPage";
            this.btnBackToTopUpPage.Size = new System.Drawing.Size(75, 23);
            this.btnBackToTopUpPage.TabIndex = 4;
            this.btnBackToTopUpPage.Text = "Back";
            this.btnBackToTopUpPage.UseVisualStyleBackColor = true;
            this.btnBackToTopUpPage.Click += new System.EventHandler(this.btnBackToTopUpPage_Click);
            // 
            // RequestRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 271);
            this.Controls.Add(this.btnBackToTopUpPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.listBoxRefunds);
            this.Name = "RequestRefundForm";
            this.Text = "Request Refund";
            this.Load += new System.EventHandler(this.TopUpDetailForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRefunds;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToTopUpPage;
    }
}