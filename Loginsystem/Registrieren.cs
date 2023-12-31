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
        public Registrieren()
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
            Menue MenueForm = new Menue();
            MenueForm.Show();
        }


        // Nicht löschen ... Wichtig -> Verbindung zur DB
        static string connectionString = @"Password=123456;Persist Security Info=True;User ID=User;Initial Catalog=DB;Data Source=DESKTOP-G9GPCBT\SQLEXPRESS,1433";

        static SqlConnection connection = new SqlConnection(connectionString);


        /// <summary>
        /// Regristrastion von User mit einer MS-SQL Server Abnbindung.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrieren_button_Click(object sender, EventArgs e)
        {
            string checkUsername = "SELECT Username FROM User1 WHERE username ='" + benutzername_textBox.Text.ToString() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername, connection);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                if (vorname_textBox.Text != "" && name_textBox.Text != "" && gebDatum_textBox.Text != "" && passwort_textBox.Text != ""
                    && benutzername_textBox.Text != "")
                {

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Benutzername schon vergeben");
                    }
                    else
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

                        ClearFields();
                        AddPlaceholder();
                    }
                }
                else
                {
                    MessageBox.Show("Du bist bereits regristriert");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            vorname_textBox.Text = "";
            name_textBox.Text = "";
            gebDatum_textBox.Text = "";
            passwort_textBox.Text = "";
            benutzername_textBox.Text = "";
        }

        private void AddPlaceholder()
        {
            // Placeholder Zuordnung
            vorname_textBox.AddPlaceholder("Vorname");
            name_textBox.AddPlaceholder("Name");
            gebDatum_textBox.AddPlaceholder("Geburtsdatum");
            benutzername_textBox.AddPlaceholder("Benutzername");
            passwort_textBox.AddPlaceholder("Passwort");
        }
    }
}
