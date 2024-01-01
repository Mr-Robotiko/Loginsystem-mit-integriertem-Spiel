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
            //FügeBeispieldatenHinzu();
        }

        /// <summary>
        /// Der Username aus dem Loginform wird hier übergeben.
        /// </summary>
        public string Username
        {
            get { return this.nutzer_label.Text; }
            set { this.nutzer_label.Text = value; }
        }

        private void FügeBeispieldatenHinzu()
        {
            string beispieltext1 = "Hallo, Ozkanaft_83!";
            nutzer_label.Text = beispieltext1;

            string beispieltext2 = "Persönlicher Highscore: 02367";
            persoenlicherHighscore_label.Text = beispieltext2;

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

        private void zurueck_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menue menueForm = new Menue();
            menueForm.Show();

            this.Hide();
        }
    }
}
