
namespace WFA_McAdam
{
    partial class ReportForm
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
            this.lblRevenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExtraRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBestBurger = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRevenue.Location = new System.Drawing.Point(12, 103);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(159, 90);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "500";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRevenue.Click += new System.EventHandler(this.lblRevenue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Gelir";
            // 
            // lblExtraRevenue
            // 
            this.lblExtraRevenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExtraRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtraRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExtraRevenue.Location = new System.Drawing.Point(198, 103);
            this.lblExtraRevenue.Name = "lblExtraRevenue";
            this.lblExtraRevenue.Size = new System.Drawing.Size(137, 90);
            this.lblExtraRevenue.TabIndex = 0;
            this.lblExtraRevenue.Text = "500";
            this.lblExtraRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExtraRevenue.Click += new System.EventHandler(this.lblExtraRevenue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toplam Ekstra Gelir";
            // 
            // lblBestBurger
            // 
            this.lblBestBurger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBestBurger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBestBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBestBurger.Location = new System.Drawing.Point(413, 103);
            this.lblBestBurger.Name = "lblBestBurger";
            this.lblBestBurger.Size = new System.Drawing.Size(434, 90);
            this.lblBestBurger.TabIndex = 0;
            this.lblBestBurger.Text = "xxxx Hamburger";
            this.lblBestBurger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "En Çok Satan Burger";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBestBurger);
            this.Controls.Add(this.lblExtraRevenue);
            this.Controls.Add(this.lblRevenue);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExtraRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBestBurger;
        private System.Windows.Forms.Label label4;
    }
}