using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginsystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}