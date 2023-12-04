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
            EckenAbrundung.RundeEcken(this, 20);
            EckenAbrundung.RundeEcken(login_panel1, 20);
            EckenAbrundung.RundeEcken(login_panel2, 20);
            EckenAbrundung.RundeEcken(login_panel3, 15);
            EckenAbrundung.RundeEcken(login_panel4, 10);
            EckenAbrundung.RundeEcken(login_panel5, 10);
            EckenAbrundung.RundeEcken(login_benutzername_textBox, 10);
            EckenAbrundung.RundeEcken(login_passwort_textBox, 10);
            EckenAbrundung.RundeEcken(abbrechen_button, 15);
            EckenAbrundung.RundeEcken(anmelden_button, 15);
        }
    }
}