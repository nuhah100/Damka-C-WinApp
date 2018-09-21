namespace Damka
{
    partial class fDamka
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
            this.pbStartscreen = new System.Windows.Forms.PictureBox();
            this.Stopwatch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStartscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStartscreen
            // 
            this.pbStartscreen.BackColor = System.Drawing.Color.White;
            this.pbStartscreen.Location = new System.Drawing.Point(0, -1);
            this.pbStartscreen.Name = "pbStartscreen";
            this.pbStartscreen.Size = new System.Drawing.Size(506, 496);
            this.pbStartscreen.TabIndex = 0;
            this.pbStartscreen.TabStop = false;
            this.pbStartscreen.Paint += new System.Windows.Forms.PaintEventHandler(this.PbStartscreen_Paint);
            this.pbStartscreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbStartscreen_MouseClick);
            // 
            // Stopwatch
            // 
            this.Stopwatch.Enabled = true;
            // 
            // fDamka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(648, 625);
            this.Controls.Add(this.pbStartscreen);
            this.Name = "fDamka";
            this.Text = "D A M K A";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fDamka_FormClosed);
            this.Load += new System.EventHandler(this.fDamka_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fDamka_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fDamka_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbStartscreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStartscreen;
        public System.Windows.Forms.Timer Stopwatch;
    }
}

