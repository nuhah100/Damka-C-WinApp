namespace Damka
{
    partial class fAbout
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
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAbout.Location = new System.Drawing.Point(2, 3);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(349, 351);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 363);
            this.Controls.Add(this.lblAbout);
            this.Name = "fAbout";
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fAbout_FormClosed);
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
    }
}