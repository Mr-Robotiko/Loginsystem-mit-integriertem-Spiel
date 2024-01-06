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
    public partial class NutzerBearbeiten : Form
    {
        public NutzerBearbeiten()
        {
            InitializeComponent();
        }

        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zurueck_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
