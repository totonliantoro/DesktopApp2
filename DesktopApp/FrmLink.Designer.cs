//***********************************************************************************************
//Programmer: Toton Liantoro
//Date: 13 October 2022
//Software: Microsoft Visual Studio 2022 Community Edition
//Platform: Microsoft Windows 11 64-bit
//Purpose: To complete the assignment 2 Subject: Apply Advance Object-Oriented Language Skills
//***********************************************************************************************

namespace Assessment2_Toton
{
    partial class FrmLink
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.txtBoxSuburb = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxResult = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(81, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(309, 393);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(115, 28);
            this.btnPreviousPage.TabIndex = 1;
            this.btnPreviousPage.Text = "Previous Page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // txtBoxSuburb
            // 
            this.txtBoxSuburb.Location = new System.Drawing.Point(40, 127);
            this.txtBoxSuburb.Name = "txtBoxSuburb";
            this.txtBoxSuburb.Size = new System.Drawing.Size(178, 22);
            this.txtBoxSuburb.TabIndex = 2;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(46, 108);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(138, 16);
            this.lblSuburb.TabIndex = 3;
            this.lblSuburb.Text = "Input your suburb here";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(330, 125);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(74, 26);
            this.btnForward.TabIndex = 5;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(330, 195);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(85, 25);
            this.btnBackward.TabIndex = 6;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Character list of your suburb";
            // 
            // lstBoxResult
            // 
            this.lstBoxResult.FormattingEnabled = true;
            this.lstBoxResult.ItemHeight = 16;
            this.lstBoxResult.Location = new System.Drawing.Point(460, 116);
            this.lstBoxResult.Name = "lstBoxResult";
            this.lstBoxResult.Size = new System.Drawing.Size(108, 180);
            this.lstBoxResult.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(330, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 27);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(563, 398);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(88, 24);
            this.nxtBtn.TabIndex = 11;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // FrmLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtBoxSuburb);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnExit);
            this.Name = "FrmLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubly-Link List";
            this.Load += new System.EventHandler(this.FrmLink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.TextBox txtBoxSuburb;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button nxtBtn;
    }
}