using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Datenbank.DBDateSetTableAdapters;

namespace Datenbank
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();

            // Nicht löschen !!! Ist der Verbindungsweg zur DB
            string connectionString = ConfigurationManager.ConnectionStrings["Datenbank.Properties.Settings.DBConnectionString"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowUsers()
        {
            // Alle zusäzlichen SQL Anweisungen bitte im Try-Catch Format schreiben
            // Sollten Daten abgefragt werden, die vielleicht verändert werden, kompiliert der Code trotzdem.
            try
            {
                string querry = "SELECT * FROM USER1";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(querry, sqlConnection);

                // Um Daten auszugeben, müssen Objekte erzeugt werden. Bspw. DataTable --> ListBox
                // Wie sollen die Daten ausgegeben werden...
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ShowStatistics()
        {
            try
            {
                string querry = "SELECT * FROM STATISTIC";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(querry, sqlConnection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }          
        }

        public void AssociatedHighscore()
        {
            // Alle zusäzlichen SQL Anweisungen bitte im Try-Catch Format schreiben
            // Sollten Daten abgefragt werden, die vielleicht verändert werden, kompiliert der Code trotzdem.
            try
            {
                string querry = "SELECT u.Name, u.Prename, s.Highscore FROM User1 u INNER JOIN Statistic s ON u.User_ID = s.Statistic_ID";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(querry, sqlConnection);

                // Um Daten auszugeben, müssen Objekte erzeugt werden. Bspw. DataTable --> ListBox
                // Wie sollen die Daten ausgegeben werden...
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
