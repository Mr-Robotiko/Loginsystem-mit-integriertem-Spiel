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
        }

        /// <summary>
        /// Der Username aus dem Loginform wird hier übergeben.
        /// </summary>
        public string Username
        {
            get { return this.nutzer_label.Text; }
            set { this.nutzer_label.Text = value; }
        }
        /// <summary>
        /// Application wird geschlossen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zurueck_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Zurück zum Menü
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Menue menueForm = new Menue();
            menueForm.Show();

            this.Hide();
        }

        /// <summary>
        /// Das Spiel wird über diesen Knopf gestartet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spielen_button_Click(object sender, EventArgs e)
        {
            Game_Spaceshooter game1 = new Game_Spaceshooter();
            game1.Show();

            this.Hide();
        }
    }
}
