namespace ZaverecnaPrace
{
    partial class Zamestnanci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odhlásitSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaměstnanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.správaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ulozit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.prijmeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mzda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datumNarozeni = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.kraj = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pohlavi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmeno_tabulka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeni_tabulka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pohlavi_tabulka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj_tabulka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumNarozeni_tabulka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mzda_tabulka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 100);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Image = global::ZaverecnaPrace.Properties.Resources.close_window;
            this.Exit.Location = new System.Drawing.Point(1035, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(36, 36);
            this.Exit.TabIndex = 10;
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(481, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaměstnanci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASIČSKÝ ZACHRANNÝ SBOR";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(67)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.zobrazitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem1,
            this.importToolStripMenuItem,
            this.odhlásitSeToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.exportToolStripMenuItem.Text = "Soubor";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // odhlásitSeToolStripMenuItem
            // 
            this.odhlásitSeToolStripMenuItem.Name = "odhlásitSeToolStripMenuItem";
            this.odhlásitSeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.odhlásitSeToolStripMenuItem.Text = "Odhlásit se";
            this.odhlásitSeToolStripMenuItem.Click += new System.EventHandler(this.odhlásitSeToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // zobrazitToolStripMenuItem
            // 
            this.zobrazitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaměstnanciToolStripMenuItem,
            this.správaToolStripMenuItem});
            this.zobrazitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zobrazitToolStripMenuItem.Name = "zobrazitToolStripMenuItem";
            this.zobrazitToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zobrazitToolStripMenuItem.Text = "Zobrazit";
            // 
            // zaměstnanciToolStripMenuItem
            // 
            this.zaměstnanciToolStripMenuItem.Enabled = false;
            this.zaměstnanciToolStripMenuItem.Name = "zaměstnanciToolStripMenuItem";
            this.zaměstnanciToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zaměstnanciToolStripMenuItem.Text = "Zaměstnanci";
            // 
            // správaToolStripMenuItem
            // 
            this.správaToolStripMenuItem.Name = "správaToolStripMenuItem";
            this.správaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.správaToolStripMenuItem.Text = "Správa";
            this.správaToolStripMenuItem.Click += new System.EventHandler(this.správaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.Ulozit);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.prijmeni);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Mzda);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.datumNarozeni);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.kraj);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pohlavi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.jmeno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 597);
            this.panel2.TabIndex = 1;
            // 
            // Ulozit
            // 
            this.Ulozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(67)))));
            this.Ulozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ulozit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ulozit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ulozit.Location = new System.Drawing.Point(135, 458);
            this.Ulozit.Name = "Ulozit";
            this.Ulozit.Size = new System.Drawing.Size(86, 35);
            this.Ulozit.TabIndex = 14;
            this.Ulozit.Text = "Uložit";
            this.Ulozit.UseVisualStyleBackColor = false;
            this.Ulozit.Click += new System.EventHandler(this.Ulozit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Příjmení";
            // 
            // prijmeni
            // 
            this.prijmeni.Location = new System.Drawing.Point(16, 140);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(205, 27);
            this.prijmeni.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "MENU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(67)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(16, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Přidat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Pridat_Click);
            // 
            // Mzda
            // 
            this.Mzda.Location = new System.Drawing.Point(16, 416);
            this.Mzda.Name = "Mzda";
            this.Mzda.Size = new System.Drawing.Size(205, 27);
            this.Mzda.TabIndex = 10;
            this.Mzda.Text = "30000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mzda";
            // 
            // datumNarozeni
            // 
            this.datumNarozeni.Location = new System.Drawing.Point(16, 351);
            this.datumNarozeni.Name = "datumNarozeni";
            this.datumNarozeni.Size = new System.Drawing.Size(200, 27);
            this.datumNarozeni.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datum narození";
            // 
            // kraj
            // 
            this.kraj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kraj.FormattingEnabled = true;
            this.kraj.Items.AddRange(new object[] {
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
            "Moravskoslezský kraj"});
            this.kraj.Location = new System.Drawing.Point(16, 285);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(205, 27);
            this.kraj.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kraj";
            // 
            // pohlavi
            // 
            this.pohlavi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pohlavi.FormattingEnabled = true;
            this.pohlavi.Items.AddRange(new object[] {
            "Muž",
            "Žena"});
            this.pohlavi.Location = new System.Drawing.Point(16, 220);
            this.pohlavi.Name = "pohlavi";
            this.pohlavi.Size = new System.Drawing.Size(205, 27);
            this.pohlavi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pohlaví";
            // 
            // jmeno
            // 
            this.jmeno.Location = new System.Drawing.Point(16, 73);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(205, 27);
            this.jmeno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jméno ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.jmeno_tabulka,
            this.prijmeni_tabulka,
            this.pohlavi_tabulka,
            this.Kraj_tabulka,
            this.datumNarozeni_tabulka,
            this.mzda_tabulka});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(239, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 597);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // jmeno_tabulka
            // 
            this.jmeno_tabulka.HeaderText = "Jméno";
            this.jmeno_tabulka.Name = "jmeno_tabulka";
            this.jmeno_tabulka.ReadOnly = true;
            // 
            // prijmeni_tabulka
            // 
            this.prijmeni_tabulka.HeaderText = "Přijmení";
            this.prijmeni_tabulka.Name = "prijmeni_tabulka";
            this.prijmeni_tabulka.ReadOnly = true;
            // 
            // pohlavi_tabulka
            // 
            this.pohlavi_tabulka.HeaderText = "Pohlaví";
            this.pohlavi_tabulka.Name = "pohlavi_tabulka";
            this.pohlavi_tabulka.ReadOnly = true;
            // 
            // Kraj_tabulka
            // 
            this.Kraj_tabulka.HeaderText = "Kraj";
            this.Kraj_tabulka.Name = "Kraj_tabulka";
            this.Kraj_tabulka.ReadOnly = true;
            // 
            // datumNarozeni_tabulka
            // 
            this.datumNarozeni_tabulka.HeaderText = "Datum narození";
            this.datumNarozeni_tabulka.Name = "datumNarozeni_tabulka";
            this.datumNarozeni_tabulka.ReadOnly = true;
            // 
            // mzda_tabulka
            // 
            this.mzda_tabulka.HeaderText = "Mzda";
            this.mzda_tabulka.Name = "mzda_tabulka";
            this.mzda_tabulka.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(909, 74);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(88, 23);
            this.date.TabIndex = 15;
            this.date.Text = "Načítám...";
            // 
            // Zamestnanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 697);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1083, 697);
            this.MinimumSize = new System.Drawing.Size(1083, 697);
            this.Name = "Zamestnanci";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaměstnanci";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox kraj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pohlavi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumNarozeni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mzda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox jmeno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prijmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odhlásitSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaměstnanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem správaToolStripMenuItem;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Ulozit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmeno_tabulka;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeni_tabulka;
        private System.Windows.Forms.DataGridViewTextBoxColumn pohlavi_tabulka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj_tabulka;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumNarozeni_tabulka;
        private System.Windows.Forms.DataGridViewTextBoxColumn mzda_tabulka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
    }
}