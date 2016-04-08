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

namespace MechanizmLogowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string danePolaczenia = "datasource=localhost; port=3306; username=root; password=";
                MySqlConnection con1 = new MySqlConnection(danePolaczenia);
                MySqlCommand command1 = new MySqlCommand("select * from testowapracownicy.pracownicy where login ='" + this.TextBoxLog.Text + "' and haslo = '" + this.TextBoxPas.Text + "';", con1);

                MySqlDataReader czytnik;
                con1.Open();
                czytnik = command1.ExecuteReader();
                int licznik = 0;
                while (czytnik.Read())
                {
                    licznik = licznik + 1;

                }
                if(licznik == 1)
                {
                    MessageBox.Show("Poprawnie Zweryfikowano uzytkownika");
                    this.Hide();
                    Form2 okno2 = new Form2();
                    okno2.Show();
                    
                }
                else if(licznik > 1)
                {
                    MessageBox.Show("Duplikacja uzytkonikow. Brak dostepu");
                }
                else
                {
                    MessageBox.Show("Nie ma uzytkowników o podanym loginie i hasle!!");
                }

                con1.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
