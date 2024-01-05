using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Loginsystem
{
    public partial class Nutzer : Form
    {
        int score;

        public Nutzer()
        {
            InitializeComponent();
            nutzer_Load();
        }
        /// <summary>
        /// Der Username aus dem Loginform wird hier überg eben.
        /// </summary>
        /// 
        public int Highscore
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public string Username
        {
            get { return this.nutzer_label.Text; }
            set { this.nutzer_label.Text = value; }
        }

        public string UsernameGame1
        {
            get { return this.nutzer_label.Text; }
            set { this.nutzer_label.Text = value; }
        }

        private void nutzer_Load()
        {

            // Nicht löschen --- Connection String zur DB
            ConnectionString connectionClass = new ConnectionString();
            string connectionToday = connectionClass.Connection_Today();
            SqlConnection connection = new SqlConnection(connectionToday);

            CheckConnection(connection);

            try
            {
                FillGlobalHighscore(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            game1.Usernamegame = nutzer_label.Text;
            game1.ShowDialog();
        }

        /// <summary>
        /// Verbindung wird geprüft
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
        /// Füllt die den globalen Highscore
        /// </summary>
        /// <param name="connection"></param>
        private void FillGlobalHighscore(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT username, SUM([Highscore]) AS Highscore FROM [dbo].[Statistic] INNER JOIN User1 ON User_ID = FK_User_ID GROUP BY Username ORDER BY Highscore DESC", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            globalerHighscore_listBox.DisplayMember = "Username";
            globalerHighscore_listBox.ValueMember = "[Username]";

            globalerHighscore_listBox.DataSource = dataTable;

            connection.Close();
        }

        private void Nutzer_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dBDataSet.User1". Sie können sie bei Bedarf verschieben oder entfernen.
            this.user1TableAdapter.Fill(this.dBDataSet.User1);

        }
    }
}
