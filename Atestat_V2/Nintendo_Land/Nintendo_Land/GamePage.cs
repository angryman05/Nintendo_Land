using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Nintendo_Land.MainPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nintendo_Land
{
    public partial class GamePage : Form
    {
        private string gamenr;
        private int gameId;
        private int userid;
        private string linkpath =$@"{Directory.GetCurrentDirectory()}\Links.txt";
        private string descrPath = $@"{Directory.GetCurrentDirectory()}\Descrieri\";
        private string bannerPath = $@"{Directory.GetCurrentDirectory()}\Banners\";
        private string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataDB.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False";
        private string gamelink;
        private string price;
        private int userRating = 0;
        private float GameRating = 0;
        private int TempRating = 0;
        private int Level = 0;
        private int btnpress = 0;
        private int isreviewed;
        private bool isupdatedonly = false;
        private bool isinserted = false;
        public GamePage(string gameid)
        {
            InitializeComponent();
            this.gamenr = gameid;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            MainPage back = new MainPage();
            this.Visible = false;
            back.ShowDialog();
            this.Close();
            
            
        }

        private void GamePage_Load(object sender, EventArgs e)
        {
            LoadRatingData(gamenr);
            LoadVideo();
            LoadBanner();
            LoadTitle(gamenr);
            LoadDescription();
            LoadConsoleIcon(gamenr);
            LoadPrice(gamenr);
            LoadGenre(gamenr);
            LoadPublisher(gamenr);
            verifyreview();
            getuserid();

        }

        private void LoadRatingData(string gamenr)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT Id FROM Games WHERE gameid = @gamenr";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gamenr", gamenr);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    gameId = int.Parse(reader["Id"].ToString());
                }


                reader.Close();
            }

            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT AVG(CAST(Score AS FLOAT)) from Reviews WHERE idGame = @gameid GROUP BY idGame";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gameid", gameId);
                try
                {
                    // Handle potential null value gracefully
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        float avgScore = Convert.ToSingle(result);
                        lblGameRating.Text = $"{avgScore:F2}"; // Format to 2 decimal places
                        lblGameRating.Text += @"\5"; // Add newline and "\5"
                        GameRating = avgScore;
                    }
                    else
                    {
                        // Handle case where no average score is found
                        lblGameRating.Text = "No rating available";
                    }
                }
                catch (SqlException ex)
                {
                    // Handle database errors appropriately
                    Console.WriteLine("Error retrieving average score: " + ex.Message);
                }

            }

            UpdateMainGameDB(gameId);
        }

        private void UpdateMainGameDB(int gameId)
        {
            var con = new SqlConnection(connstr);

            con.Open();

            string query = "UPDATE Games set rating  = @rating where Id = @gameid";

            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rating", GameRating);
            cmd.Parameters.AddWithValue("@gameid", gameId);
            cmd.ExecuteNonQuery();

            con.Dispose();
            cmd.Dispose();
            con.Close();
            

        }

        private void LoadPublisher(string gamenr)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT publisher FROM Games WHERE gameid = @gamenr";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gamenr", gamenr);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    lblPublisher.Text = lblPublisher.Text + " " + reader["publisher"].ToString();

                reader.Close();
            }
        }

        private void LoadGenre(string gamenr)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT genre FROM Games WHERE gameid = @gamenr";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gamenr", gamenr);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    lblGenre.Text = lblGenre.Text + " " + reader["genre"].ToString();

                reader.Close();
            }
        }

        private void LoadPrice(string gamenr)
        {
            StreamReader sr = new StreamReader(linkpath);
            string line;
            string[] s;
            char[] sep = {'#'};
            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                string l = s[1];
                string p = s[2];
                if(gamenr == s[0])
                {
                    gamelink = l;
                    price = p;
                }
            }

            btn_Buy.Text = price;
        }

        private void LoadConsoleIcon(string gamenr)
        {
            int consoleid = 0;
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT consoleid FROM Games WHERE gameid = @gamenr";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gamenr", gamenr);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    consoleid = int.Parse(reader["consoleid"].ToString());

                reader.Close();
            }

            pbPlatform.Image = imgListConsole.Images[consoleid];


        }

        private void LoadTitle(string gamenr)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT title FROM Games WHERE gameid = @gamenr";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gamenr", gamenr);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTitle.Text = reader["title"].ToString();
                    lblBuy.Text = lblBuy.Text + " " + reader["title"].ToString();
                }
                    

                reader.Close();
            }
        }

        private void LoadDescription()
        {
            StreamReader sr = new StreamReader(descrPath + gamenr + ".txt");
            string line;
            line = sr.ReadToEnd();
            lblDesc.Text = line;
            sr.Close();
            sr.Dispose();
        }


        private void LoadBanner()
        {
            pbBanner.Image = Image.FromFile(bannerPath + gamenr +".png");
        }

        private void LoadVideo()
        {
            string finurl = gamenr + ".mp4";
            axWindowsMediaPlayer1.URL = finurl.ToString();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(gamelink);
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[1];
            pbStar4.Image = imgListStars.Images[1];
            pbStar5.Image = imgListStars.Images[1];
            userRating = 5;
            lblYourRateNumber.Text = userRating.ToString();
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[1];
            pbStar4.Image = imgListStars.Images[1];
            pbStar5.Image = imgListStars.Images[0];
            userRating = 4;
            lblYourRateNumber.Text = userRating.ToString();
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[1];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
            userRating = 3;
            lblYourRateNumber.Text = userRating.ToString();
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[0];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
            userRating = 2;
            lblYourRateNumber.Text = userRating.ToString();
        }

        private void pbStar1_Click(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[0];
            pbStar3.Image = imgListStars.Images[0];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
            userRating = 1;
            lblYourRateNumber.Text = userRating.ToString();
        }

        private void btnPostRating_Click(object sender, EventArgs e)
        {
            TempRating = userRating;
            LoadRatingData(gamenr);
            btnpress++;

            verifyreview();

            if (lblGameRating.Text == "No rating available")
            {
                insertReview();
                LevelUp();
                verifyreview();
            }   
            else
            {
                if (isreviewed == 1)
                    updateReview();
                else
                {
                    insertReview();
                    LevelUp();
                    
                }
                    
            }

        
            LoadRatingData(gamenr);
            

        }

        private void insertReview()
        {
            int k = 1;
                var con = new SqlConnection(connstr);
                con.Open();
                string query = "INSERT INTO Reviews VALUES(@userid,@gameid,@rating,@isreviewed)";

                var cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@gameid", gameId);
                cmd.Parameters.AddWithValue("@rating", TempRating);
                cmd.Parameters.AddWithValue("@isReviewed", k);
                cmd.ExecuteNonQuery();

                con.Close();
                con.Dispose();
                cmd.Dispose();

                isinserted = true;
                isupdatedonly = false;
            
        }

        private void updateReview()
        {
            var con = new SqlConnection(connstr);
            con.Open();
            string query = "UPDATE Reviews SET Score = @rating WHERE idUser = @userid AND idGame = @gameid";
            
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rating", TempRating);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameid", gameId);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();

            isupdatedonly = true; 
            isinserted = false;
        }

        private void getuserid()
        {
            string username = "";
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT username FROM Session";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    username = reader["username"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT Id FROM Users WHERE username = @username";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("username",username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userid = int.Parse(reader["Id"].ToString());
                }
            }
        }

        private void verifyreview()
        {
            int k = 0;
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();


                string query = "SELECT isReviewed FROM Reviews WHERE idUser = @userid AND idGame = @gameid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@gameid", gameId);

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read()) 
                   k = int.Parse(reader["isReviewed"].ToString());
                

                reader.Close();
            }

            isreviewed = k;
        }

        private void LevelUp()
        {
            GetCurrentLevel();
            Level++;
            UpdateLevel(Level);
        }

        private void UpdateLevel(int level)
        {
            var con = new SqlConnection(connstr);
            con.Open();
            string query = "UPDATE Session SET level = @level";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@level",level);
            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose(); cmd.Dispose();
        }

        private void GetCurrentLevel()
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT level FROM Session";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Level = int.Parse(reader["level"].ToString());
                }
            }
        }

        private void pbStar1_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[0];
            pbStar3.Image = imgListStars.Images[0];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
        }

        private void pbStar2_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[0];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
        }

        private void pbStar3_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[1];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
        }

        private void pbStar4_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[1];
            pbStar4.Image = imgListStars.Images[1];
            pbStar5.Image = imgListStars.Images[0];
        }

        private void pbStar5_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = imgListStars.Images[1];
            pbStar2.Image = imgListStars.Images[1];
            pbStar3.Image = imgListStars.Images[1];
            pbStar4.Image = imgListStars.Images[1];
            pbStar5.Image = imgListStars.Images[1];
        }

        private void MouseLeaveF()
        {
            pbStar1.Image = imgListStars.Images[0];
            pbStar2.Image = imgListStars.Images[0];
            pbStar3.Image = imgListStars.Images[0];
            pbStar4.Image = imgListStars.Images[0];
            pbStar5.Image = imgListStars.Images[0];
        }
    }
}
