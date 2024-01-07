using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginsystem
{
    public partial class PasswortVergessen : Form
    {
        bool isregistered;

        public PasswortVergessen()
        {
            InitializeComponent();
            AddPlaceholder();
        }

        /// <summary>
        /// Führt zurück ins Loginform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zurueck_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Beendet das Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Platzhalter werden hinzugefügt
        /// </summary>
        public void AddPlaceholder()
        {
            // Placeholder Zuordnung
            benutzername_textBox.AddPlaceholder("Benutzername");
            neuesPasswort_textBox.AddPlaceholder("Neues Passwort");
        }

        /// <summary>
        /// Lässt das Passwort des Nutzers ändern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anmelden_button_Click(object sender, EventArgs e)
        {
            // Nicht löschen ... Wichtig -> Verbindung zur DB
            // Connection String wird instanziiert.
            ConnectionString connectionClass = new ConnectionString();
            string connectionToday = connectionClass.Connection_Today();
            SqlConnection connection = new SqlConnection(connectionToday);

            try
            {
                CheckConnection(connection);

                if (neuesPasswort_textBox.Text != "" && benutzername_textBox.Text != "")
                {
                    checkUser(connection);

                    if (isregistered)
                    {
                        UpdateUser(connection);
                        ClearFields();
                        AddPlaceholder();
                    }
                }

                else
                {
                    MessageBox.Show("Notwendige Felder wurden ausgelassen. Bitte ausfüllen.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prüft, ob ein User bereits registriert wurde.
        /// </summary>
        /// <param name="connection"></param>
        private void checkUser(SqlConnection connection)
        {
            string checkUsername = "SELECT Username FROM User1 WHERE username ='" + benutzername_textBox.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername, connection);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                isregistered = true;
            }
            else
            {
                MessageBox.Show("Benutzer nicht vorhanden");
            }
        }

        /// <summary>
        /// Prüft, ob die Verbindung bereits offen ist
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
        /// Fügt in der Datenbank einen neuen Nutzer hinzu
        /// </summary>
        /// <param name="connection"></param>
        private void UpdateUser(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("UPDATE [dbo].[User1] SET [Password] = @Password, [Username] = @Username WHERE Username = @checkUser", connection);

            command.Parameters.AddWithValue("@Password", neuesPasswort_textBox.Text);
            command.Parameters.AddWithValue("@Username", benutzername_textBox.Text);
            command.Parameters.AddWithValue("@checkUser", benutzername_textBox.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Erfolgreich geändert.");
        }


        /// <summary>
        /// Macht die Felder nach der Eingabe wieder leer.
        /// </summary>
        private void ClearFields()
        {
            benutzername_textBox.Text = "";
            neuesPasswort_textBox.Text = "";
        }
    }
}
