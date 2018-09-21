namespace Damka
{
    partial class fStartScreen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tFlashing = new System.Windows.Forms.Timer(this.components);
            this.pcbDamka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDamka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.Location = new System.Drawing.Point(25, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(295, 57);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Location = new System.Drawing.Point(25, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(295, 57);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAbout.Location = new System.Drawing.Point(25, 145);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(295, 57);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tFlashing
            // 
            this.tFlashing.Enabled = true;
            this.tFlashing.Interval = 500;
            this.tFlashing.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbDamka
            // 
            this.pcbDamka.BackColor = System.Drawing.Color.Transparent;
            this.pcbDamka.Location = new System.Drawing.Point(2, 2);
            this.pcbDamka.Name = "pcbDamka";
            this.pcbDamka.Size = new System.Drawing.Size(338, 65);
            this.pcbDamka.TabIndex = 3;
            this.pcbDamka.TabStop = false;
            this.pcbDamka.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbDamka_Paint);
            // 
            // fStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 291);
            this.Controls.Add(this.pcbDamka);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Name = "fStartScreen";
            this.Text = "S T A R T   S C R E E N";
            this.Load += new System.EventHandler(this.fStartScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fStartScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDamka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer tFlashing;
        private System.Windows.Forms.PictureBox pcbDamka;
    }
}