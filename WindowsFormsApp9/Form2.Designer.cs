namespace WindowsFormsApp9
{
    partial class FeedbackDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNamee = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.btnSendReply = new System.Windows.Forms.Button();
            this.btnBackToList = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // lblNamee
            // 
            this.lblNamee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNamee.Location = new System.Drawing.Point(231, 93);
            this.lblNamee.Name = "lblNamee";
            this.lblNamee.Size = new System.Drawing.Size(100, 23);
            this.lblNamee.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblType.Location = new System.Drawing.Point(231, 140);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDate.Location = new System.Drawing.Point(231, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Message:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Response:";
            // 
            // txtReply
            // 
            this.txtReply.Location = new System.Drawing.Point(149, 334);
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(429, 26);
            this.txtReply.TabIndex = 8;
            // 
            // btnSendReply
            // 
            this.btnSendReply.Location = new System.Drawing.Point(216, 382);
            this.btnSendReply.Name = "btnSendReply";
            this.btnSendReply.Size = new System.Drawing.Size(102, 32);
            this.btnSendReply.TabIndex = 9;
            this.btnSendReply.Text = "Send Reply";
            this.btnSendReply.UseVisualStyleBackColor = true;
            this.btnSendReply.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackToList
            // 
            this.btnBackToList.Location = new System.Drawing.Point(363, 382);
            this.btnBackToList.Name = "btnBackToList";
            this.btnBackToList.Size = new System.Drawing.Size(109, 32);
            this.btnBackToList.TabIndex = 10;
            this.btnBackToList.Text = "Back To List";
            this.btnBackToList.UseVisualStyleBackColor = true;
            this.btnBackToList.Click += new System.EventHandler(this.btnBackToList_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMessage.Location = new System.Drawing.Point(146, 262);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(432, 26);
            this.lblMessage.TabIndex = 11;
            // 
            // FeedbackDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnBackToList);
            this.Controls.Add(this.btnSendReply);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNamee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FeedbackDetailForm";
            this.Text = "FeedbackDetailForm";
            this.Load += new System.EventHandler(this.FeedbackDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNamee;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.Button btnSendReply;
        private System.Windows.Forms.Button btnBackToList;
        private System.Windows.Forms.Label lblMessage;
    }
}