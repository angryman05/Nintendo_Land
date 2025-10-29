using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Nintendo_Land
{

    public partial class MainPage : Form
    {
        private string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataDB.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\..\";

        public string Gameid { get; private set; }
        private string UserName = "";
        string pfpPath = "";
        int FinalLevel = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public class Game
        {
            public string Title { get; set; }
            public string Publisher { get; set; }
            public string Platform { get; set; }
            public string Genre { get; set; }
            public float Rating { get; set; }
            public string GameId { get; set; }


        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            GetSessionDetails();
            pbPFP.ImageLocation = pfpPath;

            int k = 0;
            List<Game> games = GetGames();
            foreach (Game game in games)
            {

                Button button = new Button();
                button.Name = game.GameId;
                button.Size = new Size(107, 159);
                button.Text = "";
                button.BackgroundImage = Image.FromFile(game.GameId + ".png");
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.FlatStyle = FlatStyle.Flat;
                button.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(button);

                flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

                Label label = new Label();
                label.Text = game.Title;
                label.ForeColor = Color.White;
                label.Font = new Font("Segoe UI Semibold",9,FontStyle.Bold);
                label.AutoSize = true;
                label.MaximumSize = new Size(button.Width, 0);
                label.TextAlign = ContentAlignment.MiddleCenter;


                flowLayoutPanel1.Controls.Add(label);

                int desiredLabelWidth = Math.Min(button.Width, label.MaximumSize.Width);
                label.Location = new Point(button.Location.X + (button.Width / 2) - (desiredLabelWidth / 2), button.Location.Y + button.Height);
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                k++;
            }


        }


        private void GetSessionDetails()
        {
            string username = "";
            int level = 0;
            using(SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT username,level,pfpPath FROM Session";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    username = reader["username"].ToString();
                    level = int.Parse(reader["level"].ToString());
                    FinalLevel = level;
                    pfpPath = reader["pfpPath"].ToString();
                }
            }

            lblUsername.Text = username;
            UserName = username;
            lblLevel.Text = lblLevel.Text + " " + level;
            if (level >= 100)
            {
                lblLevel.ForeColor = Color.Gold;
                progressBar1.Value = 100;
            }
            else
                progressBar1.Value = level;

            if(level >= 75)
                lblLevel.ForeColor = Color.Silver;

            if (level >= 50)
                lblLevel.ForeColor = Color.Orange;

            if (level >= 25)
                lblLevel.ForeColor = Color.Red;

            if (level >= 5)
                lblLevel.ForeColor = Color.Green;


        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string gameid = btn.Name;
            GamePage frm = new GamePage(gameid);
            //this.Visible = false;
            frm.Show();
            this.Hide();

        }

        private List<Game> GetGames()
        {
            List<Game> games = new List<Game>();

            using (SqlConnection con = new SqlConnection(connstr))
            {
                con.Open();

                string query = "SELECT title,publisher,platform,genre,rating,gameid FROM Games";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    Game game = new Game();
                    game.Title = reader["title"].ToString();
                    game.Publisher = reader["publisher"].ToString();
                    game.Platform = reader["platform"].ToString();
                    game.Genre = reader["genre"].ToString();
                    game.Rating = float.Parse(reader["rating"].ToString());
                    game.GameId = reader["gameid"].ToString();
                    games.Add(game);


                }

                reader.Close();
            }

            return games;
        }

        private void editPfp_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName;

                    pbPFP.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            pfpPath = imagelocation;
            updatePfp(pfpPath);
        }

        private void updatePfp(string pfpPath)

        {
            var con = new SqlConnection(connstr);
            con.Open();
            string query = "UPDATE Session SET pfpPath = @pfpPath";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pfpPath",pfpPath);
            cmd.ExecuteNonQuery();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SaveUserDetails(UserName);
            EndSession(UserName);
            this.Close();
            Welcome back = new Welcome();
            back.Show();
        }

        private void SaveUserDetails(string userName)
        {
            GetSessionDetails();

            var con = new SqlConnection(connstr);
            con.Open();
            string query = "UPDATE Users SET level = @level, pfpPath = @pfpPath WHERE username = @username";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@level", FinalLevel);
            cmd.Parameters.AddWithValue("@pfpPath", pfpPath);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();

        }

        private void EndSession(string UserName)
        {
            var con = new SqlConnection(connstr);
            con.Open();
            string query = "DELETE FROM Session WHERE username = @UserName";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nintendo.co.uk/News/News-Updates-11145.html");
        }

        private void bnt_Youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@NintendoAmerica");
        }
    }
}
