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
using System.Data.Sql;

namespace Loginsystem
{
    public partial class Registrieren : Form
    {
        bool isregistered = false;

        public Registrieren()
        {
            InitializeComponent();
            AddPlaceholder();
        }

        /// <summary>
        /// Applikation wird beendet
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
        /// <summary>
        /// Regristrastion von User mit einer MS-SQL Server Abnbindung.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrieren_button_Click(object sender, EventArgs e)
        {

            // Nicht löschen ... Wichtig -> Verbindung zur DB
            // Connection String wird instanziiert.
            ConnectionString connectionClass = new ConnectionString();
            string connectionToday = connectionClass.Connection_Today();
            SqlConnection connection = new SqlConnection(connectionToday);

            try
            {
                CheckConnection(connection);

                if (vorname_textBox.Text != "" && name_textBox.Text != "" && gebDatum_textBox.Text != "" && passwort_textBox.Text != ""
                    && benutzername_textBox.Text != "")
                {
                    checkUser(connection);

                    if (!isregistered)
                    {
                        AddUser(connection);
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
        /// Macht die Felder nach der Eingabe wieder leer.
        /// </summary>
        private void ClearFields()
        {
            vorname_textBox.Text = "";
            name_textBox.Text = "";
            gebDatum_textBox.Text = "";
            passwort_textBox.Text = "";
            benutzername_textBox.Text = "";
        }
        /// <summary>
        /// Platzhalter für die Textboxen werden zurückgesetzt
        /// </summary>
        private void AddPlaceholder()
        {
            // Placeholder Zuordnung
            vorname_textBox.AddPlaceholder("Vorname");
            name_textBox.AddPlaceholder("Name");
            gebDatum_textBox.AddPlaceholder("Geburtsdatum");
            benutzername_textBox.AddPlaceholder("Benutzername");
            passwort_textBox.AddPlaceholder("Passwort");
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
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Benutzername schon vergeben");
                isregistered = true;
            }
        }

        /// <summary>
        /// Fügt in der Datenbank einen neuen Nutzer hinzu
        /// </summary>
        /// <param name="connection"></param>
        private void AddUser(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("INSERT INTO User1 VALUES(@Prename, @Name, @Birthday,@Rights_Status, @Password, @Username)", connection);

            command.Parameters.AddWithValue("@Prename", vorname_textBox.Text);
            command.Parameters.AddWithValue("@Name", name_textBox.Text);
            command.Parameters.AddWithValue("@Birthday", Convert.ToDateTime(gebDatum_textBox.Text));
            command.Parameters.AddWithValue("@Password", passwort_textBox.Text);
            command.Parameters.AddWithValue("@Rights_Status", 'U');
            command.Parameters.AddWithValue("@Username", benutzername_textBox.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Erfolgreich regrisitriert");
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
    }
}