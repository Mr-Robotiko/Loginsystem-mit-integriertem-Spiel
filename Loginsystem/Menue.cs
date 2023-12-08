using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Loginsystem
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void menue_beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menue_anmelden_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void menue_registrieren_button_Click(object sender, EventArgs e)
        {
            Registrieren registrieren = new Registrieren();
            registrieren.Show();
        }
    }
}