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
    public partial class UpravitOsobu : Form
    {
        private string[] originalData; // Pole pro uchování původních dat

        public UpravitOsobu(string[] rowData)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            Ovladaní.TimerManager.Initialize(date);
            


            originalData = rowData; // Uložení původních dat

            SetFormData(rowData); // Nastavení formuláře se zadanými daty
        }

        // Metoda pro nastavení dat na formuláři
        private void SetFormData(string[] data)
        {
            label3.Text += data[0]; // ID
            jmeno.Text = data[1]; // Jméno
            prijmeni.Text = data[2]; // Příjmení
            pohlavi.Text = data[3]; // Pohlaví
            kraj.Text = data[4]; // Kraj
            datumNarozeni.Text = data[5]; // Datum narození
            Mzda.Text = data[6]; // Mzda
        }

        // Metoda pro aktualizaci záznamu v souboru
        private void AktualizovatZaznamVeSouboru(string[] newData)
        {
            // Cesta k souboru
            string filePath = Path.Combine(Application.StartupPath, "default.txt");

            // Ověření existence souboru
            if (File.Exists(filePath))
            {
                try
                {
                    // Přečtení všech řádků ze souboru
                    string[] lines = File.ReadAllLines(filePath);

                    // Procházení všech řádků a hledání odpovídajícího záznamu na základě ID
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split('\t');

                        // Pokud je ID záznamu stejné jako ID původních dat, provede se aktualizace
                        if (parts[0] == originalData[0])
                        {
                            // Nahrazení řádku novými daty
                            lines[i] = string.Join("\t", newData);
                            break; // Není třeba dále procházet záznamy
                        }
                    }

                    // Přepsání souboru s aktualizovanými daty
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Záznam byl úspěšně aktualizován.");
                }
                catch (Exception ex)
                {
                    // Zachycení a zpracování chyby
                    MessageBox.Show("Chyba při aktualizaci záznamu: " + ex.Message);
                }
            }
            else
            {
                // Pokud soubor neexistuje, zobrazte chybovou zprávu
                MessageBox.Show("Soubor neexistuje.");
            }
        }

        private void Zamestanci_Click(object sender, EventArgs e)
        {
            Ovladaní.Zamestnanci();
            this.Close();
        }

        private void správaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ovladaní.Edit();
            this.Close();
        }

        private void odhlásitSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Ovladaní.Odhlaseni();
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ovladaní.UkonceniAplikace();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Ovladaní.UkonceniAplikace();
        }

        private void Ulozit_Click(object sender, EventArgs e)
        {
            // Vytvoření pole nových dat
            string[] newData = {
                originalData[0], // ID zůstává stejné
                jmeno.Text, // Jméno
                prijmeni.Text, // Příjmení
                pohlavi.Text, // Pohlaví
                kraj.Text, // Kraj
                datumNarozeni.Text, // Datum narození
                Mzda.Text // Mzda
            };

            // Aktualizace záznamu v souboru
            AktualizovatZaznamVeSouboru(newData);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Přesměrování na obrazovku zaměstnanců pro import, pokud je třeba
            DialogResult result = MessageBox.Show("Chyba: Není možné importovat z této obrazovky. Chcete být přesměrován na obrazovku zaměstnanců, kde můžete provádět import?", "Chyba", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                Ovladaní.Zamestnanci();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }
    }
}
