using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Datenbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Datenbank.Properties.Settings.DBConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
