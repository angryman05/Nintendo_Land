namespace Nintendo_Land
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPlatform = new System.Windows.Forms.PictureBox();
            this.lblBuy = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.imgListConsole = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgListStars = new System.Windows.Forms.ImageList(this.components);
            this.lblYouRate = new System.Windows.Forms.Label();
            this.lblYourRateNumber = new System.Windows.Forms.Label();
            this.btnPostRating = new System.Windows.Forms.Button();
            this.lblGameRating = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(12, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 21);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Game title";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPublisher.Location = new System.Drawing.Point(802, 384);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(101, 20);
            this.lblPublisher.TabIndex = 3;
            this.lblPublisher.Text = "Published by:";
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDesc.Location = new System.Drawing.Point(803, 247);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(501, 124);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Game description";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(246, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Go back to the main page";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.Color.Transparent;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRating.Location = new System.Drawing.Point(803, 404);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(57, 20);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Nintendo_Land.Properties.Resources.partialBackgrounds;
            this.panel1.Controls.Add(this.pbPlatform);
            this.panel1.Controls.Add(this.lblBuy);
            this.panel1.Controls.Add(this.btn_Buy);
            this.panel1.Location = new System.Drawing.Point(16, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 100);
            this.panel1.TabIndex = 7;
            // 
            // pbPlatform
            // 
            this.pbPlatform.BackColor = System.Drawing.Color.Transparent;
            this.pbPlatform.Image = global::Nintendo_Land.Properties.Resources.topkek;
            this.pbPlatform.Location = new System.Drawing.Point(690, 4);
            this.pbPlatform.Name = "pbPlatform";
            this.pbPlatform.Size = new System.Drawing.Size(59, 34);
            this.pbPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatform.TabIndex = 2;
            this.pbPlatform.TabStop = false;
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuy.Location = new System.Drawing.Point(23, 31);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(49, 30);
            this.lblBuy.TabIndex = 1;
            this.lblBuy.Text = "Buy";
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.Color.Green;
            this.btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buy.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Buy.ForeColor = System.Drawing.Color.White;
            this.btn_Buy.Location = new System.Drawing.Point(570, 44);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(179, 53);
            this.btn_Buy.TabIndex = 0;
            this.btn_Buy.Text = "Price";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // imgListConsole
            // 
            this.imgListConsole.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListConsole.ImageStream")));
            this.imgListConsole.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListConsole.Images.SetKeyName(0, "1.png");
            this.imgListConsole.Images.SetKeyName(1, "2.png");
            this.imgListConsole.Images.SetKeyName(2, "3.png");
            this.imgListConsole.Images.SetKeyName(3, "4.png");
            this.imgListConsole.Images.SetKeyName(4, "5.png");
            this.imgListConsole.Images.SetKeyName(5, "6.jpeg");
            this.imgListConsole.Images.SetKeyName(6, "7.png");
            this.imgListConsole.Images.SetKeyName(7, "8.png");
            this.imgListConsole.Images.SetKeyName(8, "9.png");
            this.imgListConsole.Images.SetKeyName(9, "10.png");
            this.imgListConsole.Images.SetKeyName(10, "11.png");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1011, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(293, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit the app";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGenre.Location = new System.Drawing.Point(803, 424);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(58, 21);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre:";
            // 
            // lblYour
            // 
            this.lblYour.AutoSize = true;
            this.lblYour.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYour.Location = new System.Drawing.Point(6, 163);
            this.lblYour.Name = "lblYour";
            this.lblYour.Size = new System.Drawing.Size(90, 20);
            this.lblYour.TabIndex = 1;
            this.lblYour.Text = "Your rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(845, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Give this game a rating from 1 to 5!";
            // 
            // imgListStars
            // 
            this.imgListStars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListStars.ImageStream")));
            this.imgListStars.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListStars.Images.SetKeyName(0, "SpriteEmpty.png");
            this.imgListStars.Images.SetKeyName(1, "SpriteFull.png");
            // 
            // lblYouRate
            // 
            this.lblYouRate.AutoSize = true;
            this.lblYouRate.BackColor = System.Drawing.Color.Transparent;
            this.lblYouRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYouRate.Location = new System.Drawing.Point(820, 618);
            this.lblYouRate.Name = "lblYouRate";
            this.lblYouRate.Size = new System.Drawing.Size(94, 21);
            this.lblYouRate.TabIndex = 17;
            this.lblYouRate.Text = "Your rating:";
            // 
            // lblYourRateNumber
            // 
            this.lblYourRateNumber.AutoSize = true;
            this.lblYourRateNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblYourRateNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYourRateNumber.ForeColor = System.Drawing.Color.Black;
            this.lblYourRateNumber.Location = new System.Drawing.Point(908, 617);
            this.lblYourRateNumber.Name = "lblYourRateNumber";
            this.lblYourRateNumber.Size = new System.Drawing.Size(23, 25);
            this.lblYourRateNumber.TabIndex = 18;
            this.lblYourRateNumber.Text = "0";
            // 
            // btnPostRating
            // 
            this.btnPostRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPostRating.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPostRating.Location = new System.Drawing.Point(1074, 599);
            this.btnPostRating.Name = "btnPostRating";
            this.btnPostRating.Size = new System.Drawing.Size(199, 57);
            this.btnPostRating.TabIndex = 19;
            this.btnPostRating.Text = "Post your rating!";
            this.btnPostRating.UseVisualStyleBackColor = true;
            this.btnPostRating.Click += new System.EventHandler(this.btnPostRating_Click);
            // 
            // lblGameRating
            // 
            this.lblGameRating.AutoSize = true;
            this.lblGameRating.BackColor = System.Drawing.Color.Transparent;
            this.lblGameRating.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameRating.Location = new System.Drawing.Point(859, 404);
            this.lblGameRating.Name = "lblGameRating";
            this.lblGameRating.Size = new System.Drawing.Size(41, 21);
            this.lblGameRating.TabIndex = 20;
            this.lblGameRating.Text = "0.00";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 75);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(769, 460);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // pbStar5
            // 
            this.pbStar5.BackColor = System.Drawing.Color.Transparent;
            this.pbStar5.Image = global::Nintendo_Land.Properties.Resources.SpriteEmpty;
            this.pbStar5.Location = new System.Drawing.Point(1199, 512);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(65, 68);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar5.TabIndex = 15;
            this.pbStar5.TabStop = false;
            this.pbStar5.Click += new System.EventHandler(this.pbStar5_Click);
            this.pbStar5.MouseHover += new System.EventHandler(this.pbStar5_MouseHover);
            // 
            // pbStar4
            // 
            this.pbStar4.BackColor = System.Drawing.Color.Transparent;
            this.pbStar4.Image = global::Nintendo_Land.Properties.Resources.SpriteEmpty;
            this.pbStar4.Location = new System.Drawing.Point(1105, 512);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(65, 68);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar4.TabIndex = 14;
            this.pbStar4.TabStop = false;
            this.pbStar4.Click += new System.EventHandler(this.pbStar4_Click);
            this.pbStar4.MouseHover += new System.EventHandler(this.pbStar4_MouseHover);
            // 
            // pbStar3
            // 
            this.pbStar3.BackColor = System.Drawing.Color.Transparent;
            this.pbStar3.Image = global::Nintendo_Land.Properties.Resources.SpriteEmpty;
            this.pbStar3.Location = new System.Drawing.Point(1011, 512);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(65, 68);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar3.TabIndex = 13;
            this.pbStar3.TabStop = false;
            this.pbStar3.Click += new System.EventHandler(this.pbStar3_Click);
            this.pbStar3.MouseHover += new System.EventHandler(this.pbStar3_MouseHover);
            // 
            // pbStar2
            // 
            this.pbStar2.BackColor = System.Drawing.Color.Transparent;
            this.pbStar2.Image = global::Nintendo_Land.Properties.Resources.SpriteEmpty;
            this.pbStar2.Location = new System.Drawing.Point(913, 512);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(65, 68);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar2.TabIndex = 12;
            this.pbStar2.TabStop = false;
            this.pbStar2.Click += new System.EventHandler(this.pbStar2_Click);
            this.pbStar2.MouseHover += new System.EventHandler(this.pbStar2_MouseHover);
            // 
            // pbStar1
            // 
            this.pbStar1.BackColor = System.Drawing.Color.Transparent;
            this.pbStar1.Image = global::Nintendo_Land.Properties.Resources.SpriteEmpty;
            this.pbStar1.Location = new System.Drawing.Point(824, 512);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(65, 68);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar1.TabIndex = 11;
            this.pbStar1.TabStop = false;
            this.pbStar1.Click += new System.EventHandler(this.pbStar1_Click);
            this.pbStar1.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbBanner
            // 
            this.pbBanner.Image = global::Nintendo_Land.Properties.Resources.topkek;
            this.pbBanner.Location = new System.Drawing.Point(806, 75);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(498, 169);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBanner.TabIndex = 1;
            this.pbBanner.TabStop = false;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nintendo_Land.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 688);
            this.Controls.Add(this.lblGameRating);
            this.Controls.Add(this.btnPostRating);
            this.Controls.Add(this.lblYourRateNumber);
            this.Controls.Add(this.lblYouRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbStar5);
            this.Controls.Add(this.pbStar4);
            this.Controls.Add(this.pbStar3);
            this.Controls.Add(this.pbStar2);
            this.Controls.Add(this.pbStar1);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePage";
            this.Load += new System.EventHandler(this.GamePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPlatform;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.ImageList imgListConsole;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYour;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgListStars;
        private System.Windows.Forms.Label lblYouRate;
        private System.Windows.Forms.Label lblYourRateNumber;
        private System.Windows.Forms.Button btnPostRating;
        private System.Windows.Forms.Label lblGameRating;
    }
}