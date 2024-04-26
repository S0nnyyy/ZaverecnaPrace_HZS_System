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
    public partial class Zamestnanci : Form
    {
        private int currentID = 0;

        public Zamestnanci()
        {
            InitializeComponent();


            Ovladaní.TimerManager.Initialize(date);



            timer1.Interval = 1000; 

            // Nastavení obsluhy události Tick
            timer1.Tick += timer1_Tick;

            // Spuštění timeru
            timer1.Start();


            // Načtení dat ze souboru default.txt při spuštění formuláře
            string filePath = Path.Combine(Application.StartupPath, "default.txt");
            if (File.Exists(filePath))
            {
                Ovladaní.ImportFromTxt(filePath, dataGridView1);

                // Nastavení aktuálního ID na nejvyšší existující ID z načtených dat
                currentID = GetHighestID(dataGridView1) + 1;
            }
            else
            {
                MessageBox.Show(Application.StartupPath + " Soubor default.txt neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetHighestID(DataGridView dataGridView)
        {
            int highestID = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id;
                    if (int.TryParse(row.Cells["ID"].Value.ToString(), out id))
                    {
                        if (id > highestID)
                        {
                            highestID = id;
                        }
                    }
                }
            }
            return highestID;
        }

        private void Pridat_Click(object sender, EventArgs e)
        {
            // Získání hodnot z TextBoxů
            // Předpokládám, že sloupec ID má název "ID"
            int newID = currentID++; // Zvýšení aktuálního ID a použití pro nový záznam

            String jmenoInput = jmeno.Text;
            String prijmeniInput = prijmeni.Text;
            String pohlaviInput = pohlavi.Text;
            String krajInput = kraj.Text;
            String datumNarozeniInput = datumNarozeni.Text;
            String mzdaInput = Mzda.Text;

            // Ověření, zda jsou všechny vstupy vyplněny
            if (string.IsNullOrEmpty(jmenoInput) ||
                string.IsNullOrEmpty(prijmeniInput) ||
                string.IsNullOrEmpty(pohlaviInput) ||
                string.IsNullOrEmpty(krajInput) ||
                string.IsNullOrEmpty(datumNarozeniInput) ||
                string.IsNullOrEmpty(mzdaInput))
            {
                MessageBox.Show("Všechny údaje musí být vyplněny.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Pokud některý z údajů chybí, přerušíme operaci
            }

            // Ověření, zda je mzda platné číslo
            decimal mzdaValue;
            if (!decimal.TryParse(mzdaInput, out mzdaValue))
            {
                MessageBox.Show("Mzda musí být platné číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Pokud mzda není platné číslo, přerušíme operaci
            }

            // Přidání řádku do DataGridView s vyplněnými hodnotami
            string[] row = { newID.ToString(), jmenoInput, prijmeniInput, pohlaviInput, krajInput, datumNarozeniInput, mzdaInput };
            dataGridView1.Rows.Add(row);

            // Vyčištění TextBoxů po přidání záznamu
            jmeno.Text = "";
            prijmeni.Text = "";
            pohlavi.SelectedIndex = -1;
            kraj.SelectedIndex = -1;
            datumNarozeni.Text = "";
            Mzda.Text = "";
        }

        private void Ulozit_Click(object sender, EventArgs e)
        {
            // Zeptejte se uživatele, zda je jistý uložením dat
            DialogResult result = MessageBox.Show("Opravdu chcete uložit data? Tím přepíšete stávající soubor 'default.txt'.", "Potvrzení uložení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Získání cesty k souboru default.txt
                string filePath = Path.Combine(Application.StartupPath, "default.txt");

                try
                {
                    // Otevření souboru pro zápis (přepíše existující soubor)
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        // Projděte každý řádek v DataGridView a uložte ho do souboru
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value.ToString());
                                    // Pokud je to poslední buňka v řádku, nepište tabulátor
                                    if (i < dataGridView1.Columns.Count - 1)
                                    {
                                        sw.Write("\t");
                                    }
                                }
                                // Nový řádek pro oddělení dat
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Data byla úspěšně uložena do souboru 'default.txt'.", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Pokud dojde k chybě při zápisu do souboru, zobrazte chybovou zprávu
                    MessageBox.Show("Chyba při ukládání dat: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Otevření dialogu pro výběr umístění a názvu souboru
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt";
            saveFileDialog.Title = "Export dat do textového souboru";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Ovladaní.ExportToTxt(saveFileDialog.FileName, dataGridView1);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otevření dialogu pro výběr souboru k importu
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textové soubory (*.txt)|*.txt";
            openFileDialog.Title = "Import dat z textového souboru";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Zobrazení upozornění na nenávratnost akce
                DialogResult result = MessageBox.Show("Tato akce smaže všechna stávající data. Opravdu chcete pokračovat?", "Potvrzení nenávratné akce", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Pokud uživatel potvrdí, že chce pokračovat, provede se import dat a přepíše původní soubor
                        Ovladaní.ImportFromTxt(openFileDialog.FileName, dataGridView1);

                        // Přepíšeme soubor default.txt novými daty
                        File.Copy(openFileDialog.FileName, Path.Combine(Application.StartupPath, "default.txt"), true);

                        MessageBox.Show("Data byla úspěšně importována a soubor byl přepsán.", "Import úspěšný", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Při importu dat došlo k chybě: {ex.Message}", "Chyba importu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }
    }
}
