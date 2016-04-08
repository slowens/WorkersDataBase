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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int idpom = 1;

        
        private void button1_Click(object sender, EventArgs e)
        {

            string login = this.nazwisko.Text;
            login = login + this.imie.Text[0];
            login = login.ToLower();
            string zapytanieBazy = "insert into testowapracownicy.pracownicy (id, imie, nazwisko, login, haslo, dzial, wynagrodzenie) values( NULL,'" + this.imie.Text + "', '" + this.nazwisko.Text + "','" + login + "','" + login + "','" + this.dzial.Text + "','" + this.kwota.Text + "');";

            string danePolaczenia = "datasource=localhost; port=3306; username=root; password=";
            MySqlConnection con1 = new MySqlConnection(danePolaczenia);
            MySqlCommand zapytanie = new MySqlCommand(zapytanieBazy,con1);

            MySqlDataReader czytnik;



            try
            {
                con1.Open();
                czytnik = zapytanie.ExecuteReader();
                MessageBox.Show("Zapisano!");

                while (czytnik.Read())
                {
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con1.Close();

            this.imie.Text = "";
            this.nazwisko.Text = "";
            this.dzial.Text = "";
            this.kwota.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = this.nazwisko.Text;
            login = login + this.imie.Text[0];
            login = login.ToLower();
            string zapytanieBazy = "insert into testowapracownicy.pracownicy (imie, nazwisko, login, haslo, dzial, wynagrodzenie) values('" + this.imie.Text + "', '" + this.nazwisko.Text + "','" + login + "','" + login + "','" + this.dzial.Text + "','" + this.kwota.Text + "');";

            string danePolaczenia = "datasource=localhost; port=3306; username=root; password=";
            MySqlConnection con1 = new MySqlConnection(danePolaczenia);
            MySqlCommand zapytanie = new MySqlCommand(zapytanieBazy, con1);

            MySqlDataReader czytnik;



            try
            {
                con1.Open();
                czytnik = zapytanie.ExecuteReader();
                MessageBox.Show("Zapisano!");

                while (czytnik.Read())
                {


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con1.Close();

            this.imie.Text = "";
            this.nazwisko.Text = "";
            this.dzial.Text = "";
            this.kwota.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                string danePolaczenia1 = "datasource=localhost; port=3306; username=root; password=";
                string query1 = "select id, imie, nazwisko, dzial, wynagrodzenie from testowapracownicy.pracownicy where id = "+ idpom +";";
                MySqlConnection con2 = new MySqlConnection(danePolaczenia1);
                MySqlCommand command2 = new MySqlCommand(query1, con2);

                MySqlDataReader czytnik1;
                con2.Open();
                czytnik1 = command2.ExecuteReader();
                while (czytnik1.Read())
                {
                    BazaID.Text = ((int)czytnik1[0]).ToString();
                    BazaImie.Text = (string)czytnik1[1];
                    BazaNazwisko.Text = (string)czytnik1[2];
                    BazaDzial.Text = (string)czytnik1[3];
                    BazaKwota.Text = ((decimal)czytnik1[4]).ToString();

                }

                czytnik1.Close();
                czytnik1 = null;
                command2.Dispose();
                command2 = null;
                con2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idpom >1)
            {
                idpom--;
                Form2_Load(sender, e);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idpom++;
            Form2_Load(sender, e);
        }
    }
}
