﻿namespace Prize
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
            this.components = new System.ComponentModel.Container();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnRandToggler = new System.Windows.Forms.Button();
            this.randTimer = new System.Windows.Forms.Timer(this.components);
            this.cok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(235, 59);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(235, 51);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Tag = "";
            this.lblEventName.Text = "Arisan Grosir";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(217, 107);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(275, 65);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "MONDELEZ";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(179, 218);
            this.lblRandomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(450, 103);
            this.lblRandomNumber.TabIndex = 2;
            this.lblRandomNumber.Text = "0 0 0 0";
            this.lblRandomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRandToggler
            // 
            this.btnRandToggler.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandToggler.Location = new System.Drawing.Point(283, 375);
            this.btnRandToggler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRandToggler.Name = "btnRandToggler";
            this.btnRandToggler.Size = new System.Drawing.Size(263, 70);
            this.btnRandToggler.TabIndex = 3;
            this.btnRandToggler.Text = "Mulai Acak";
            this.btnRandToggler.UseVisualStyleBackColor = true;
            this.btnRandToggler.Click += new System.EventHandler(this.btnRandToggler_Click);
            // 
            // randTimer
            // 
            this.randTimer.Interval = 1;
            this.randTimer.Tick += new System.EventHandler(this.randTimer_Tick);
            // 
            // cok
            // 
            this.cok.AutoSize = true;
            this.cok.Location = new System.Drawing.Point(0, 0);
            this.cok.Name = "cok";
            this.cok.Size = new System.Drawing.Size(35, 13);
            this.cok.TabIndex = 4;
            this.cok.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.cok);
            this.Controls.Add(this.btnRandToggler);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblEventName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arisan Grosir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnRandToggler;
        private System.Windows.Forms.Timer randTimer;
        private System.Windows.Forms.Label cok;
    }
}

