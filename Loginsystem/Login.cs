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

        private void anmelden_button_Click(object sender, EventArgs e)
        {
            // Nicht löschen --- Connection String zur DB
             string connectionString = @"Password=123456;Persist Security Info=True;User ID=User;Initial Catalog=DB;Data Source=79.234.68.27,1433";

             SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                if (benutzername_textBox.Text != "" && passwort_textBox.Text != "")
                {

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Username, Password FROM User1 WHERE username='" + benutzername_textBox.Text.ToString() + "' AND password= '" + passwort_textBox.Text.ToString() + "'", connection);;
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        MessageBox.Show("Herzlich Willkommen" +" "+ benutzername_textBox.Text);

                        Nutzer nutzerForm = new Nutzer();
                        nutzerForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Falsches Passwort oder Username");
                    }

                    ClearFields();
                    AddPlaceholder();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddPlaceholder()
        {
            // Placeholder Zuordnung
            benutzername_textBox.AddPlaceholder("Benutzername");
            passwort_textBox.AddPlaceholder("Passwort");
        }

        public void ClearFields()
        {
            benutzername_textBox.Text = "";
            passwort_textBox.Text = "";
        }
    }
}