using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nintendo_Land
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void tmrProg_Tick(object sender, EventArgs e)
        {
            progB1.Value++;
            if(progB1.Value == 100) 
            {
                tmrProg.Enabled = false;
                Welcome frm = new Welcome();
                frm.Show();
                this.Hide();

            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            tmrProg.Enabled=true;
        }
    }
}
