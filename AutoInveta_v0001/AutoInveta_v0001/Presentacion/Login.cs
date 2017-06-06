using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInveta_v0001
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Usuario uu = new Usuario();
            uu.Show();
            timer1.Enabled = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = true;
        }

      
        private void Loading_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;
        }
    }
}
