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
        //static string connectionString = @"Password=123456;Persist Security Info=True;User ID=User;Initial Catalog=DB;Data Source=DESKTOP-G9GPCBT\SQLEXPRESS";

        static string connstring = @"Password=123456;Persist Security Info=True;User ID=User;Initial Catalog=DB;Data Source=DESKTOP-G9GPCBT\SQLEXPRESS,1433;Integrated Security=true";

        static SqlConnection connection = new SqlConnection(connstring);


        /// <summary>
        /// Regristrastion von User mit einer MS-SQL Server Abnbindung.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrieren_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                if(vorname_textBox.Text != "" && name_textBox.Text != "" && gebDatum_textBox.Text != "" && passwort_textBox.Text != "" 
                    && benutzername_textBox.Text != "")
                {
                    SqlCommand command = new SqlCommand("INSERT INTO User1 VALUES(@Prename, @Name, @Birthday,@Rights_Status, @Password)", connection);

                    command.Parameters.AddWithValue("@Prename", vorname_textBox.Text);
                    command.Parameters.AddWithValue("@Name", name_textBox.Text);
                    command.Parameters.AddWithValue("@Birthday", Convert.ToDateTime(gebDatum_textBox.Text));
                    command.Parameters.AddWithValue("@Password", passwort_textBox.Text);
                    command.Parameters.AddWithValue("@Rights_Status", 'U');
                   
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Erfolgreich regrisitriert");

                    ClearFieldds();
                    AddPlaceholder();
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
        private void ClearFieldds()
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
