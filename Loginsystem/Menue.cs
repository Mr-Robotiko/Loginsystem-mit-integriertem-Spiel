using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginsystem
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anmelden_button_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            this.Hide();
        }

        private void registrieren_button_Click(object sender, EventArgs e)
        {
            Registrieren registrierenForm = new Registrieren();
            registrierenForm.Show();

            this.Hide();
        }
    }
}
