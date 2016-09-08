namespace Prize
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
            this.btnRandToggler = new System.Windows.Forms.Button();
            this.randTimer = new System.Windows.Forms.Timer(this.components);
            this.cok = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.arisanType = new System.Windows.Forms.Label();
            this.arisanNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandToggler
            // 
            this.btnRandToggler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRandToggler.FlatAppearance.BorderSize = 0;
            this.btnRandToggler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandToggler.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandToggler.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRandToggler.Location = new System.Drawing.Point(428, 684);
            this.btnRandToggler.Name = "btnRandToggler";
            this.btnRandToggler.Size = new System.Drawing.Size(394, 121);
            this.btnRandToggler.TabIndex = 3;
            this.btnRandToggler.Text = "Mulai Acak";
            this.btnRandToggler.UseVisualStyleBackColor = false;
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
            this.cok.Location = new System.Drawing.Point(12, 9);
            this.cok.Name = "cok";
            this.cok.Size = new System.Drawing.Size(51, 20);
            this.cok.TabIndex = 4;
            this.cok.Text = "label1";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRandomNumber.Font = new System.Drawing.Font("Courier New", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(312, 135);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(935, 227);
            this.lblRandomNumber.TabIndex = 2;
            this.lblRandomNumber.Text = "0 0 0 0";
            this.lblRandomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arisanType
            // 
            this.arisanType.AutoSize = true;
            this.arisanType.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arisanType.Location = new System.Drawing.Point(1198, 24);
            this.arisanType.MinimumSize = new System.Drawing.Size(250, 100);
            this.arisanType.Name = "arisanType";
            this.arisanType.Size = new System.Drawing.Size(250, 100);
            this.arisanType.TabIndex = 5;
            this.arisanType.Text = "GOLD";
            this.arisanType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arisanNumber
            // 
            this.arisanNumber.AutoSize = true;
            this.arisanNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arisanNumber.Location = new System.Drawing.Point(1204, 123);
            this.arisanNumber.MinimumSize = new System.Drawing.Size(200, 0);
            this.arisanNumber.Name = "arisanNumber";
            this.arisanNumber.Size = new System.Drawing.Size(200, 81);
            this.arisanNumber.TabIndex = 6;
            this.arisanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prize.Properties.Resources.Arisan_Backdrop_011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 735);
            this.Controls.Add(this.arisanNumber);
            this.Controls.Add(this.arisanType);
            this.Controls.Add(this.cok);
            this.Controls.Add(this.btnRandToggler);
            this.Controls.Add(this.lblRandomNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arisan Grosir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnRandToggler;
        private System.Windows.Forms.Timer randTimer;
        private System.Windows.Forms.Label cok;
        private System.Windows.Forms.Label arisanType;
        private System.Windows.Forms.Label arisanNumber;
    }
}

