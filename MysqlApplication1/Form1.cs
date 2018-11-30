using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MysqlApplication1
{
    
    public partial class Form1 : Form
    {
        const string AdatLetrehoz_Sql = @"
            CREATE TABLE IF NOT EXISTS felhasznalo(
            id INTEGER AUTO_INCREMENT PRIMARY KEY,
            nev VARCHAR(80) NOT NULL UNIQUE,
            jelszo VARCHAR(100) NOT NULL,            
            regdatum DATE NOT NULL
)



";
        MySqlConnection conn;
        public Form1()
        {
            try { InitializeComponent();
                conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Password=;");
                conn.Open();
                var letrehozas = conn.CreateCommand();
                letrehozas.CommandText = AdatLetrehoz_Sql;
                letrehozas.ExecuteNonQuery();

                UpdateRegUserek();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Adatbázishiva:\n" + ex.Message);
                this.Close();
            }
        }
        private void UpdateRegUserek()
        {
            string kiirando = "Regisztralt {0} db user";
            var c = conn.CreateCommand();
            c.CommandText = "Select COUNT(*) FROM felhasznalo";
            long darabszam = (long)c.ExecuteScalar();

            regUserLabel.Text = string.Format(kiirando, darabszam);

            var cUserek = conn.CreateCommand();
            c.CommandText = "Select nev, regdatum FROM felhasznalo ORDER BY nev";
            var reader = c.ExecuteReader();
            while (reader.Read())
            {
                var nev = reader.GetString("nev");
                var datum = reader.GetDateTime("regdatum");
                felhasznalokListBox.Items.Add(
                    string.Format("{0}- {1:yyyy. MM. dd.}", nev, datum)
                    );
                    
            }







        }
        private void regButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszoTextBox.Text;
            DateTime regdatum = szuletesDateTimePicker.Value;
            
            
                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("A usernev mar letezik");
                    return;
                }

                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO felhasznalo (nev, jelszo, regdatum) VALUES (@nev, @jelszo, @regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettSorok = command.ExecuteNonQuery();

            UpdateRegUserek();
        }
    }
}
