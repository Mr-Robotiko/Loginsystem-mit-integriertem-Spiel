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
    public partial class NutzerBearbeiten : Form
    {
        bool isregistered;

        public NutzerBearbeiten()
        {
            InitializeComponent();
            AddPlaceholder();
        }

        private void beenden_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zurueck_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
        /// Macht die Felder nach der Eingabe wieder leer.
        /// </summary>
        private void ClearFields()
        {
            vorname_textBox.Text = "";
            name_textBox.Text = "";
            gebDatum_textBox.Text = "";
            benutzername_textBox.Text = "";
            passwort_textBox.Text = "";
        }

        private void bearbeiten_button_Click(object sender, EventArgs e)
        {

            // Nicht löschen ... Wichtig -> Verbindung zur DB
            // Connection String wird instanziiert.
            ConnectionString connectionClass = new ConnectionString();
            string connectionToday = connectionClass.Connection_Today();
            SqlConnection connection = new SqlConnection(connectionToday);

            try
            {
                CheckConnection(connection);

                if (vorname_textBox.Text != "Vorname" && name_textBox.Text != "Name" && gebDatum_textBox.Text != "Geburtsdatum" && passwort_textBox.Text != "Password"
                    && benutzername_textBox.Text != "Benutzername" && vorname_textBox.Text != "" && name_textBox.Text != "" && gebDatum_textBox.Text != "" && passwort_textBox.Text != ""
                    && benutzername_textBox.Text != "")
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
            SqlCommand command = new SqlCommand("UPDATE [dbo].[User1] SET [Prename] = @Prename, [Name] = @Name, [Birthday] = @Birthday,[Rights_Status] = @Rights_Status,[Password] = @Password, [Username] = @Username WHERE Username = @checkUser", connection);

            command.Parameters.AddWithValue("@Prename", vorname_textBox.Text);
            command.Parameters.AddWithValue("@Name", name_textBox.Text);
            command.Parameters.AddWithValue("@Birthday", Convert.ToDateTime(gebDatum_textBox.Text));
            command.Parameters.AddWithValue("@Rights_Status", 'U');
            command.Parameters.AddWithValue("@Password", passwort_textBox.Text);
            command.Parameters.AddWithValue("@Username", benutzername_textBox.Text);
            command.Parameters.AddWithValue("@checkUser", benutzername_textBox.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Erfolgreich geändert.");
        }

        private void loeschen_button_Click(object sender, EventArgs e)
        {
            // Nicht löschen ... Wichtig -> Verbindung zur DB
            // Connection String wird instanziiert.
            ConnectionString connectionClass = new ConnectionString();
            string connectionToday = connectionClass.Connection_Today();
            SqlConnection connection = new SqlConnection(connectionToday);

            try
            {
                CheckConnection(connection);

                if (passwort_textBox.Text != "Passwort" && passwort_textBox.Text != "" && benutzername_textBox.Text != "Benutzername" && benutzername_textBox.Text != "")
                {
                    checkUser(connection);
                    if (isregistered)
                    {
                        DeleteUser(connection);

                        Login login = new Login();
                        login.ShowDialog();

                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Bitte Nutzername und Passwort ausfüllen");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteUser(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[User1] WHERE username = @username AND Password = @Password", connection);

            command.Parameters.AddWithValue("@Username", benutzername_textBox.Text);
            command.Parameters.AddWithValue("@Password", passwort_textBox.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Erfolgreich gelöscht.");

        }

        private void NutzerBearbeiten_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Der Benutzername kann nicht geändert werden. Bitte geben Sie Ihren exestierenden Benutzernamen ein, um eine Löschung oder Bearbeitung Ihres Profils durchzuführen.");
        }
    }
}
