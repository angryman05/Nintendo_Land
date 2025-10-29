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
using static Nintendo_Land.MainPage;
using System.IO;

namespace Nintendo_Land
{
    public partial class Welcome : Form
    {
        private string defaultPfpPath = $@"{Directory.GetCurrentDirectory()}\Defaultpfp\blankpfp.png";
        private string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataDB.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False";
        public Welcome()
        {
            InitializeComponent();
        }
        int k = 1;

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (k == imageList.Images.Count)
            {
                k= 0;
            }
            else
            {
                PBRecent.Image = imageList.Images[k];
                k++;
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            PBRecent.Image= imageList.Images[0];
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtNameLog.Text;
            string pass = txtPassLog.Text;
            if(!ExistaUtilizator(user,pass))
            {
                MessageBox.Show("Username or password is incorrect!");
                txtNameLog.Text = "";
                txtPassLog.Text = "";
            }
            else
            {
                StartSession(user,pass);
                MainPage frm  = new MainPage();
                this.Visible = false;
                frm.ShowDialog();
                this.Hide();

            }
        }

        private void StartSession(string user, string pass)
        {
            string email = "";
            int level = 0;
            string tempPfp = "";

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();

                // First query to retrieve email
                string query1 = "SELECT email,level,pfpPath FROM Users WHERE username = @username";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@username", user);

                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader["email"].ToString();
                        level = int.Parse(reader["level"].ToString());
                        tempPfp = reader["pfpPath"].ToString();
                    }
                }

                if(tempPfp == null)
                {
                    tempPfp = defaultPfpPath;
                }
                    

                // Second query to insert session
                string query2 = "INSERT INTO Session VALUES(@username, @password, @email,@level,@pfpPath)";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@username", user);
                cmd2.Parameters.AddWithValue("@password", pass); // Hash password here
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@level", level);
                cmd2.Parameters.AddWithValue("@pfpPath", tempPfp);

                cmd2.ExecuteNonQuery();
            }
        }

        private bool ExistaUtilizator(string user, string pass)
        {
            string query = "SELECT COUNT (username) FROM Users WHERE username = @user AND password = @pass";
            var con = new SqlConnection(connstr);
            con.Open();
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue ("@pass", pass);
            int x = (int)cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            con.Dispose();
            return x == 1;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtNameReg.Text;
            if (user == "")
            {
                MessageBox.Show("This space cannot be empty!");
                return;
            }
            if (user.Length < 4)
            {
                MessageBox.Show("Username lenght must be longer than 4 characters!");
                return;
            }

            string pass = txtPassReg.Text;
            string confirm = txtPassConfirm.Text;

            if (pass == "" || confirm == "")
            {
                MessageBox.Show("Campul parola trebuie sa fie nevide!");
                return;
            }

            if (pass.Length < 6 || confirm.Length < 6)
            {
                MessageBox.Show("Lungimea parole trebuie sa fie cel putin sase caractere!");
                return;
            }
            if (pass != confirm)
            {
                MessageBox.Show("parola nu coincide cu confirmarea parolei!");
                return;
            }

            string email = txtEmailReg.Text;
            if (!EmailValid(email))
            {
                MessageBox.Show("Adresa de email invalida!");
                return;
            }
            InsertUtilizator(user, pass, email);
            MessageBox.Show("Account created succesfully!");
            txtNameReg.Text = "";
            txtPassReg.Text = "";
            txtPassConfirm.Text = "";
            txtEmailReg.Text = "";
        }

        private void InsertUtilizator(string user, string pass, string email)
        {
            
            int level = 0;
            var con = new SqlConnection(connstr);
            con.Open();
            string query = "INSERT INTO Users VALUES(@username,@password,@email,@level,@defaultpfp)";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username",user);
            cmd.Parameters.AddWithValue("@password",pass);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@level",level);
            cmd.Parameters.AddWithValue("@defaultpfp",defaultPfpPath);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();
        }

        private bool EmailValid(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch { return false; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
