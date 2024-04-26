using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnaPrace
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string jmeno = loginName.Text;
            string heslo = loginPassword.Text;

            // Cesta k souboru, kde jsou uložená jména a hesla
            string cestaKsouboru = "login.txt";

            try
            {
                // Načtení prvního řádku ze souboru
                string prvniRadek = File.ReadLines(cestaKsouboru).First();

                // Rozdělení řádku na jméno a heslo
                string[] oddelene = prvniRadek.Split(' ');

                // Porovnání zadaných údajů s uloženými
                if (jmeno == oddelene[0] && heslo == oddelene[1])
                {
                    // Pokud se shodují, přesměrujte na formulář zaměstnanců
                    Zamestnanci form = new Zamestnanci();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nesprávné uživatelské jméno nebo heslo.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Soubor s uživatelskými jmény a hesly nebyl nalezen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při přihlašování: " + ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Ovladaní.UkonceniAplikace();
        }
    }
}
