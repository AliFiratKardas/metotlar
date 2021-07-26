
namespace WFA_McAdam
{
    partial class Campaign
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.btnIndirim = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Location = new System.Drawing.Point(251, 144);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(137, 29);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "İndirim Kuponu";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblIndirim
            // 
            this.lblIndirim.BackColor = System.Drawing.Color.Magenta;
            this.lblIndirim.Location = new System.Drawing.Point(107, 56);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(138, 73);
            this.lblIndirim.TabIndex = 2;
            this.lblIndirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIndirim
            // 
            this.btnIndirim.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnIndirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndirim.Location = new System.Drawing.Point(110, 144);
            this.btnIndirim.Name = "btnIndirim";
            this.btnIndirim.Size = new System.Drawing.Size(135, 29);
            this.btnIndirim.TabIndex = 3;
            this.btnIndirim.Text = "Kazanılan İndirim";
            this.btnIndirim.UseVisualStyleBackColor = false;
            this.btnIndirim.Click += new System.EventHandler(this.btnIndirim_Click);
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.SpringGreen;
            this.lblCode.Location = new System.Drawing.Point(248, 56);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(137, 73);
            this.lblCode.TabIndex = 5;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // Campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(530, 243);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnIndirim);
            this.Controls.Add(this.lblIndirim);
            this.Controls.Add(this.btnRandom);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Campaign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campaign";
            this.Load += new System.EventHandler(this.Campaign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Button btnIndirim;
        private System.Windows.Forms.Label lblCode;
    }
}