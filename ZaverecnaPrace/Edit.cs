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
    public partial class Edit : Form
    {
        string[] selectedRowData;

        public Edit()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            Ovladaní.TimerManager.Initialize(date);



            // Inicializace ListView
            listViewResult.View = View.Details; // Nastaví zobrazení ListView jako detaily
            listViewResult.FullRowSelect = true; // Zvýrazní celý řádek, nikoli pouze jednotlivé buňky
            listViewResult.GridLines = true; // Zobrazí mřížku pro lepší čitelnost
            listViewResult.Columns.Add("ID", 100); // Přidá sloupec pro ID s šířkou 100px
            listViewResult.Columns.Add("Jméno", 100); // Přidá sloupec pro jméno s šířkou 100px
            listViewResult.Columns.Add("Příjmení", 100); // Přidá sloupec pro příjmení s šířkou 100px
            listViewResult.Columns.Add("Pohlaví", 100); // Přidá sloupec pro pohlaví s šířkou 100px
            listViewResult.Columns.Add("Kraj", 100); // Přidá sloupec pro kraj s šířkou 100px
            listViewResult.Columns.Add("Datum narození", 150); // Přidá sloupec pro datum narození s šířkou 150px
            listViewResult.Columns.Add("Mzda", 100); // Přidá sloupec pro mzdu s šířkou 100px
        }

        private void Vyhledat_Click(object sender, EventArgs e)
        {
            // Získání vstupních dat z ComboBoxů
            string searchFilter = selekce.Text;
            string searchText = Kriterium.Text;
            string gender = "";
            string region = "";

            // Získání hodnoty z nového ComboBoxu podle viditelnosti
            if (Specifikace.Visible)
            {
                if (selekce.Text == "Pohlaví")
                {
                    gender = Specifikace.SelectedItem.ToString();
                }
                else if (selekce.Text == "Kraje")
                {
                    region = Specifikace.SelectedItem.ToString();
                }
            }

            // Vyčištění ListView před novým vyhledáváním
            listViewResult.Items.Clear();

            // Cesta k souboru
            string filePath = Path.Combine(Application.StartupPath, "default.txt");

            // Ověření existence souboru
            if (File.Exists(filePath))
            {
                try
                {
                    // Otevření souboru pro čtení
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Rozdělení řádku podle tabulátoru
                            string[] parts = line.Split('\t');

                            // Pokud má řádek správný počet částí
                            if (parts.Length >= 7)
                            {
                                // Závisle na vybraném filtru provedeme vyhledávání
                                switch (searchFilter)
                                {
                                    case "ID":
                                        if (parts[0] == searchText)
                                        {
                                            // Přidání nové položky do ListView
                                            ListViewItem item = new ListViewItem(parts);
                                            listViewResult.Items.Add(item);
                                        }
                                        break;
                                    case "Jména":
                                        if (parts[1].ToLower().Contains(searchText.ToLower()))
                                        {
                                            // Přidání nové položky do ListView
                                            ListViewItem item = new ListViewItem(parts);
                                            listViewResult.Items.Add(item);
                                        }
                                        break;
                                    case "Příjmení":
                                        if (parts[2].ToLower().Contains(searchText.ToLower()))
                                        {
                                            // Přidání nové položky do ListView
                                            ListViewItem item = new ListViewItem(parts);
                                            listViewResult.Items.Add(item);
                                        }
                                        break;
                                    case "Pohlaví":
                                        if (gender != "" && parts[3].ToLower() == gender.ToLower())
                                        {
                                            // Přidání nové položky do ListView
                                            ListViewItem item = new ListViewItem(parts);
                                            listViewResult.Items.Add(item);
                                        }
                                        break;
                                    case "Kraje":
                                        if (region != "" && parts[4].ToLower() == region.ToLower())
                                        {
                                            // Přidání nové položky do ListView
                                            ListViewItem item = new ListViewItem(parts);
                                            listViewResult.Items.Add(item);
                                        }
                                        break;
                                    case "Mzdy":
                                        if (parts[6].ToLower().Contains(searchText.ToLower()))
                                        {
                                            // Přidání nové položky do ListView
                                            ListViewItem item = new ListViewItem(parts);
                                            listViewResult.Items.Add(item);
                                        }
                                        break;
                                    default:
                                        // Pokud filtr není platný, zobrazíme chybovou zprávu
                                        MessageBox.Show("Nesprávný filtr.");
                                        return;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Zachycení a zpracování chyby
                    MessageBox.Show("Chyba při čtení souboru: " + ex.Message);
                }
            }
            else
            {
                // Pokud soubor neexistuje, zobrazte chybovou zprávu
                MessageBox.Show("Soubor neexistuje.");
            }
        }

        private void selekce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selekce.Text == "Pohlaví")
            {
                Specifikace.Visible = true;
                Specifikace.Items.Clear();
                Specifikace.ResetText();
                Specifikace.Items.Add("Muž");
                Specifikace.Items.Add("Žena");
                Kriterium.Visible = false;
                label6.Visible = false;
                label2.Visible = true;
                label2.Text = "Vyberte pohlaví";
            }
            else if (selekce.Text == "Kraje")
            {
                Specifikace.Visible = true;
                Specifikace.Items.Clear();
                Specifikace.ResetText();
                Kriterium.Visible = false;
                label6.Visible = false;
                label2.Visible = true;
                label2.Text = "Vyberte Kraj";

                // Seznam všech krajů v České republice
                string[] regions = {
                    "Hlavní město Praha",
                    "Středočeský kraj",
                    "Jihočeský kraj",
                    "Plzeňský kraj",
                    "Karlovarský kraj",
                    "Ústecký kraj",
                    "Liberecký kraj",
                    "Královéhradecký kraj",
                    "Pardubický kraj",
                    "Vysočina",
                    "Jihomoravský kraj",
                    "Olomoucký kraj",
                    "Zlínský kraj",
                    "Moravskoslezský kraj"
                };

                // Přidání všech krajů do ComboBoxu
                foreach (string region in regions)
                {
                    Specifikace.Items.Add(region);
                }
            }
            else
            {
                Specifikace.Visible = false;
                Kriterium.Visible = true;
                label6.Visible = true;
                label2.Visible = false;
            }
        }

        private void Upravit_Click(object sender, EventArgs e)
        {
            // Kontrola zda byl vybrán řádek
            if (listViewResult.SelectedItems.Count > 0)
            {
                // Získání vybraného řádku
                ListViewItem selectedItem = listViewResult.SelectedItems[0];

                // Uložení dat do pole
                string[] selectedRowData = new string[selectedItem.SubItems.Count];
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    selectedRowData[i] = selectedItem.SubItems[i].Text;
                }

                // Otevření nového okna a předání dat
                UpravitOsobu upravitOkno = new UpravitOsobu(selectedRowData);
                upravitOkno.Show();
            }
            else
            {
                MessageBox.Show("Není vybrán žádný řádek.");
            }
        }

        private void Smazat_Click(object sender, EventArgs e)
        {
            // Kontrola zda byl vybrán řádek
            if (listViewResult.SelectedItems.Count > 0)
            {
                // Získání vybraného řádku
                ListViewItem selectedItem = listViewResult.SelectedItems[0];

                // Získání ID záznamu ke smazání
                string idToDelete = selectedItem.SubItems[0].Text;

                // Zobrazení potvrzovacího dialogu
                DialogResult result = MessageBox.Show("Opravdu chcete smazat tento záznam?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Pokud uživatel potvrdí smazání
                if (result == DialogResult.Yes)
                {
                    // Získání cesty k souboru
                    string filePath = Path.Combine(Application.StartupPath, "default.txt");

                    // Ověření existence souboru
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            // Načtení všech řádků ze souboru
                            List<string> lines = File.ReadAllLines(filePath).ToList();

                            // Odstranění řádku se zvoleným ID
                            lines.RemoveAll(line => line.StartsWith(idToDelete + "\t"));

                            // Přepsání souboru bez smazaného záznamu
                            File.WriteAllLines(filePath, lines);

                            // Zobrazení informace o úspěšném smazání
                            MessageBox.Show("Záznam byl úspěšně smazán.");

                            // Aktualizace ListView
                            Vyhledat_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            // Zachycení a zpracování chyby
                            MessageBox.Show("Chyba při mazání záznamu: " + ex.Message);
                        }
                    }
                    else
                    {
                        // Pokud soubor neexistuje, zobrazte chybovou zprávu
                        MessageBox.Show("Soubor neexistuje.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Není vybrán žádný řádek.");
            }
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Implementace exportu, pokud je třeba
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chyba: Není možné importovat z této obrazovky. Chcete být přesměrován na obrazovku zaměstnanců, kde můžete provádět import?", "Chyba", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                Ovladaní.Zamestnanci();
                this.Close();
            }
        }

        private void Zamestanci_Click(object sender, EventArgs e)
        {
            Ovladaní.Zamestnanci();
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
