namespace Nintendo_Land
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.progB1 = new System.Windows.Forms.ProgressBar();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblTM = new System.Windows.Forms.Label();
            this.tmrProg = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Nintendo_Land.Properties.Resources.nintendo_land_2_15_2024;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(248, 84);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // progB1
            // 
            this.progB1.Location = new System.Drawing.Point(-2, 358);
            this.progB1.Name = "progB1";
            this.progB1.Size = new System.Drawing.Size(731, 23);
            this.progB1.TabIndex = 1;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(53, 202);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(162, 35);
            this.lblLoad.TabIndex = 2;
            this.lblLoad.Text = "Loading...";
            // 
            // lblTM
            // 
            this.lblTM.AutoSize = true;
            this.lblTM.BackColor = System.Drawing.Color.Transparent;
            this.lblTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTM.ForeColor = System.Drawing.Color.White;
            this.lblTM.Location = new System.Drawing.Point(5, 331);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(162, 24);
            this.lblTM.TabIndex = 3;
            this.lblTM.Text = "Created by Robert";
            // 
            // tmrProg
            // 
            this.tmrProg.Interval = 30;
            this.tmrProg.Tick += new System.EventHandler(this.tmrProg_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nintendo_Land.Properties.Resources.splashscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 383);
            this.Controls.Add(this.lblTM);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.progB1);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ProgressBar progB1;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblTM;
        private System.Windows.Forms.Timer tmrProg;
    }
}

