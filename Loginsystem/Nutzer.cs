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
    public partial class Nutzer : Form
    {
        public Nutzer()
        {
            InitializeComponent();

            FügeBeispieldatenHinzu();
        }

        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zurueck_button_Click(object sender, EventArgs e)
        {
            Menue menueForm = new Menue();
            menueForm.Show();

            this.Hide();
        }

        private void FügeBeispieldatenHinzu()
        {
            // Zehn Beispieldaten erstellen und zur ListBox hinzufügen
            for (int i = 1; i <= 30; i++)
            {
                if (i <= 9)
                {         
                    globalerHighscore_listBox.Items.Add(i + ".   02367 - Ozkanaft_83");
                }

                else 
                {
                    globalerHighscore_listBox.Items.Add(i + ". 02367 - Ozkanaft_83");
                }
                
            }
        }
    }
}
