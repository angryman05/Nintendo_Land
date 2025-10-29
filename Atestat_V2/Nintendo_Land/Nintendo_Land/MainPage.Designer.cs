namespace Nintendo_Land
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.editPfp = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.bnt_Youtube = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPFP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPFP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(112, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(112, 120);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(52, 21);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Level:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(115, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(99, 21);
            this.progressBar1.TabIndex = 3;
            // 
            // editPfp
            // 
            this.editPfp.BackColor = System.Drawing.Color.DarkBlue;
            this.editPfp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editPfp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editPfp.ForeColor = System.Drawing.Color.White;
            this.editPfp.Location = new System.Drawing.Point(14, 173);
            this.editPfp.Name = "editPfp";
            this.editPfp.Size = new System.Drawing.Size(201, 60);
            this.editPfp.TabIndex = 4;
            this.editPfp.Text = "Edit profile picture";
            this.editPfp.UseVisualStyleBackColor = false;
            this.editPfp.Click += new System.EventHandler(this.editPfp_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkBlue;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(14, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(263, 38);
            this.back.TabIndex = 5;
            this.back.Text = "Go back to the main page";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bnt_Youtube
            // 
            this.bnt_Youtube.BackColor = System.Drawing.Color.DarkBlue;
            this.bnt_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_Youtube.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnt_Youtube.ForeColor = System.Drawing.Color.White;
            this.bnt_Youtube.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bnt_Youtube.Location = new System.Drawing.Point(13, 243);
            this.bnt_Youtube.Name = "bnt_Youtube";
            this.bnt_Youtube.Size = new System.Drawing.Size(201, 60);
            this.bnt_Youtube.TabIndex = 7;
            this.bnt_Youtube.Text = "Watch trailers and more on our youtube channel!";
            this.bnt_Youtube.UseVisualStyleBackColor = false;
            this.bnt_Youtube.Click += new System.EventHandler(this.bnt_Youtube_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLearn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLearn.ForeColor = System.Drawing.Color.White;
            this.btnLearn.Location = new System.Drawing.Point(12, 314);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(201, 60);
            this.btnLearn.TabIndex = 8;
            this.btnLearn.Text = "Learn more about us!";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1132, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit the application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::Nintendo_Land.Properties.Resources.backgroundpanel;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(970, 621);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // pbPFP
            // 
            this.pbPFP.Image = ((System.Drawing.Image)(resources.GetObject("pbPFP.Image")));
            this.pbPFP.Location = new System.Drawing.Point(13, 77);
            this.pbPFP.Name = "pbPFP";
            this.pbPFP.Size = new System.Drawing.Size(93, 90);
            this.pbPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPFP.TabIndex = 0;
            this.pbPFP.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nintendo_Land.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 688);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.bnt_Youtube);
            this.Controls.Add(this.back);
            this.Controls.Add(this.editPfp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbPFP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPFP;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button editPfp;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button bnt_Youtube;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
    }
}