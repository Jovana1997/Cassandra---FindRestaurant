namespace WinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.btnPrikaziRest = new System.Windows.Forms.Button();
            this.dgvRestorani = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipKuhinje = new System.Windows.Forms.ComboBox();
            this.cbVegan = new System.Windows.Forms.CheckBox();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNazivRest = new System.Windows.Forms.TextBox();
            this.btnMeni = new System.Windows.Forms.Button();
            this.dgvMeni = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.btnDostupnost = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBrojRez = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestorani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grad";
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(111, 23);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(149, 22);
            this.tbGrad.TabIndex = 1;
            // 
            // btnPrikaziRest
            // 
            this.btnPrikaziRest.Location = new System.Drawing.Point(27, 176);
            this.btnPrikaziRest.Name = "btnPrikaziRest";
            this.btnPrikaziRest.Size = new System.Drawing.Size(137, 30);
            this.btnPrikaziRest.TabIndex = 2;
            this.btnPrikaziRest.Text = "Prikazi restorane";
            this.btnPrikaziRest.UseVisualStyleBackColor = true;
            this.btnPrikaziRest.Click += new System.EventHandler(this.btnPrikaziRest_Click);
            // 
            // dgvRestorani
            // 
            this.dgvRestorani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestorani.Location = new System.Drawing.Point(27, 223);
            this.dgvRestorani.Name = "dgvRestorani";
            this.dgvRestorani.RowHeadersWidth = 51;
            this.dgvRestorani.RowTemplate.Height = 24;
            this.dgvRestorani.Size = new System.Drawing.Size(233, 234);
            this.dgvRestorani.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip kuhinje";
            // 
            // cbTipKuhinje
            // 
            this.cbTipKuhinje.FormattingEnabled = true;
            this.cbTipKuhinje.Location = new System.Drawing.Point(111, 63);
            this.cbTipKuhinje.Name = "cbTipKuhinje";
            this.cbTipKuhinje.Size = new System.Drawing.Size(149, 24);
            this.cbTipKuhinje.TabIndex = 5;
            // 
            // cbVegan
            // 
            this.cbVegan.AutoSize = true;
            this.cbVegan.Location = new System.Drawing.Point(27, 105);
            this.cbVegan.Name = "cbVegan";
            this.cbVegan.Size = new System.Drawing.Size(71, 21);
            this.cbVegan.TabIndex = 7;
            this.cbVegan.Text = "Vegan";
            this.cbVegan.UseVisualStyleBackColor = true;
            // 
            // cbGluten
            // 
            this.cbGluten.AutoSize = true;
            this.cbGluten.Location = new System.Drawing.Point(27, 132);
            this.cbGluten.Name = "cbGluten";
            this.cbGluten.Size = new System.Drawing.Size(105, 21);
            this.cbGluten.TabIndex = 8;
            this.cbGluten.Text = "Bez glutena";
            this.cbGluten.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv restorana";
            // 
            // tbNazivRest
            // 
            this.tbNazivRest.Location = new System.Drawing.Point(427, 22);
            this.tbNazivRest.Name = "tbNazivRest";
            this.tbNazivRest.Size = new System.Drawing.Size(186, 22);
            this.tbNazivRest.TabIndex = 10;
            // 
            // btnMeni
            // 
            this.btnMeni.Location = new System.Drawing.Point(500, 56);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(113, 30);
            this.btnMeni.TabIndex = 11;
            this.btnMeni.Text = "Prikazi Meni";
            this.btnMeni.UseVisualStyleBackColor = true;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // dgvMeni
            // 
            this.dgvMeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeni.Location = new System.Drawing.Point(285, 105);
            this.dgvMeni.Name = "dgvMeni";
            this.dgvMeni.RowHeadersWidth = 51;
            this.dgvMeni.RowTemplate.Height = 24;
            this.dgvMeni.Size = new System.Drawing.Size(328, 352);
            this.dgvMeni.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rezervacija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Restoran";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vreme";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(732, 62);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(152, 22);
            this.tbNaziv.TabIndex = 17;
            // 
            // btnDostupnost
            // 
            this.btnDostupnost.Location = new System.Drawing.Point(678, 190);
            this.btnDostupnost.Name = "btnDostupnost";
            this.btnDostupnost.Size = new System.Drawing.Size(206, 30);
            this.btnDostupnost.TabIndex = 20;
            this.btnDostupnost.Text = "Proveri dostupnost";
            this.btnDostupnost.UseVisualStyleBackColor = true;
            this.btnDostupnost.Click += new System.EventHandler(this.btnDostupnost_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dostupno:";
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Location = new System.Drawing.Point(792, 360);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(92, 28);
            this.btnRezervisi.TabIndex = 22;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Prezime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(638, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Telefon";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(732, 256);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(152, 22);
            this.tbIme.TabIndex = 26;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(732, 287);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(152, 22);
            this.tbPrezime.TabIndex = 27;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(732, 318);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(152, 22);
            this.tbTelefon.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(638, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Broj osoba";
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(732, 158);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(152, 22);
            this.tbBroj.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(732, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1494, 318);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(732, 126);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker3.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(641, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Broj rezervacije";
            // 
            // tbBrojRez
            // 
            this.tbBrojRez.Location = new System.Drawing.Point(770, 411);
            this.tbBrojRez.Name = "tbBrojRez";
            this.tbBrojRez.Size = new System.Drawing.Size(114, 22);
            this.tbBrojRez.TabIndex = 35;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(792, 450);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(92, 24);
            this.btnOtkazi.TabIndex = 36;
            this.btnOtkazi.Text = "Otkazi ";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 486);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.tbBrojRez);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDostupnost);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMeni);
            this.Controls.Add(this.btnMeni);
            this.Controls.Add(this.tbNazivRest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGluten);
            this.Controls.Add(this.cbVegan);
            this.Controls.Add(this.cbTipKuhinje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRestorani);
            this.Controls.Add(this.btnPrikaziRest);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestorani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Button btnPrikaziRest;
        private System.Windows.Forms.DataGridView dgvRestorani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipKuhinje;
        private System.Windows.Forms.CheckBox cbVegan;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNazivRest;
        private System.Windows.Forms.Button btnMeni;
        private System.Windows.Forms.DataGridView dgvMeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Button btnDostupnost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbBrojRez;
        private System.Windows.Forms.Button btnOtkazi;
    }
}

