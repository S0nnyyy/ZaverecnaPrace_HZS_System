using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnaPrace
{
    public static class Ovladaní
    {

        public static void Zamestnanci()
        {
            Zamestnanci form = new Zamestnanci();
            form.Show();
        }

        public static void Edit()
        {
            Edit form = new Edit();
            form.Show();
        }

        // Metoda pro odhlášení uživatele
        public static void Odhlaseni()
        {
            Login form = new Login();
            form.Show();
            MessageBox.Show("Uživatel byl odhlášen.");
        }

        // Metoda pro ukončení aplikace
        public static void UkonceniAplikace()
        {
            Application.Exit();
        }

        public static void ImportFromTxt(string filePath, DataGridView dataGridView)
        {
            try
            {
                // Nejprve vyčistíme existující data v dataGridView
                dataGridView.Rows.Clear();

                // Načteme data ze souboru
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split('\t');
                        dataGridView.Rows.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při importu dat: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void ExportToTxt(string filePath, DataGridView dataGridView)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Data
                    for (int i = 1; i < dataGridView.Rows.Count; i++) // Začínáme od indexu 1
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            writer.Write(dataGridView.Rows[i].Cells[j].Value);
                            if (j < dataGridView.Columns.Count - 1)
                                writer.Write("\t");
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Data byla úspěšně exportována do textového souboru.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při exportu dat: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static class TimerManager
        {
            private static Timer timer = new Timer();
            private static TimeSpan elapsedTime = TimeSpan.Zero;
            private static Label sharedLabel;

            public static void Initialize(Label label)
            {
                sharedLabel = label;
                timer.Interval = 60000; // Interval 1 minuty (60000 ms)
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            private static void Timer_Tick(object sender, EventArgs e)
            {
                elapsedTime = elapsedTime.Add(TimeSpan.FromMinutes(1)); // Přidání jedné minuty
                UpdateLabel();
            }

            private static void UpdateLabel()
            {
                if (sharedLabel != null)
                {
                    sharedLabel.Text = DateTime.Now.ToString();
                }
            }

        }
    }
}
