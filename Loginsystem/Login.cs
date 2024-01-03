using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loginsystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AddPlaceholder();
        }

        /// <summary>
        /// Applikation wird geschlossen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Zurück zum Menü
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zurueck_button_Click(object sender, EventArgs e)
        {
            Menue menueForm = new Menue();
            menueForm.Show();

            this.Hide();
        }
        
        public void anmelden_button_Click(object sender, EventArgs e)
        {
            // Nicht löschen --- Connection String zur DB
            ConnectionString connectionClass = new ConnectionString();
            string connectionToday = connectionClass.Connection_Today();
            SqlConnection connection = new SqlConnection(connectionToday);

            try
            {
                CheckConnection(connection);

                if (benutzername_textBox.Text != "" && passwort_textBox.Text != "")
                {
                    CheckLogin(connection);
                    ClearFields();
                    AddPlaceholder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Platzhalter werden den Textboxen hinzugefügt
        /// </summary>
        public void AddPlaceholder()
        {
            // Placeholder Zuordnung
            benutzername_textBox.AddPlaceholder("Benutzername");
            passwort_textBox.AddPlaceholder("Passwort");
        }

        /// <summary>
        /// Die Felder der Tectboxen werden nach Eingabe gesäubert
        /// </summary>
        private void ClearFields()
        {
            benutzername_textBox.Text = "";
            passwort_textBox.Text = "";
        }

        /// <summary>
        /// Die Verbindung wird geprüft
        /// </summary>
        /// <param name="connection"></param>
        private void CheckConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Der Login wird überprüft
        /// </summary>
        /// <param name="connection"></param>
        private void CheckLogin(SqlConnection connection)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Username, Password FROM User1 WHERE username='" + benutzername_textBox.Text.ToString() + "' AND password= '" + passwort_textBox.Text.ToString() + "'", connection); ;
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Herzlich Willkommen" + " " + benutzername_textBox.Text);

                Nutzer nutzerForm = new Nutzer();
                nutzerForm.Show();

                this.Hide();

                Nutzer nutzer = new Nutzer();
                nutzer.Username = this.benutzername_textBox.Text;
                nutzer.Show();
            }
            else
            {
                MessageBox.Show("Falsches Passwort oder Username");
            }
        }
    }
}