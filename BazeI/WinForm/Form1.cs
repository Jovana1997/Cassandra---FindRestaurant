using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayerCassandra;
using DataLayerCassandra.CassandraEntities;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbTipKuhinje.Items.Add("Italijanska");
            cbTipKuhinje.Items.Add("Japanska");
            cbTipKuhinje.Items.Add("Francuska");
            cbTipKuhinje.Items.Add("Srpska");
            cbTipKuhinje.Items.Add("Evropska");
            cbTipKuhinje.Items.Add("Meksicka");
            cbTipKuhinje.Items.Add("Mediteranska");
            cbTipKuhinje.Items.Add("Medjunarodna");
            cbTipKuhinje.Items.Add("Americka");
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "hh:mm";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker1.Value.ToString("yyyy-mm-dd");
        }

        private void btnPrikaziRest_Click(object sender, EventArgs e)
        {
            string vegan, gluten;
            if (cbVegan.Checked)
                vegan = "Da";
            else vegan = "Ne";
            if (cbGluten.Checked)
                gluten = "Da";
            else gluten = "Ne";
            Table table = DataProvider.PrikaziRestorane(tbGrad.Text, cbTipKuhinje.Text, vegan, gluten);
            if (table.nazivi.Rows.Count == 0)
            {
                MessageBox.Show("Ne postoji restoran sa takvom kuhinjom u datom gradu. Proverite naziv grada!");
                tbGrad.Clear();
            }
            dgvRestorani.DataSource = table.nazivi;
        }

        private void btnMeni_Click(object sender, EventArgs e)
        {
            Table table = DataProvider.PrikaziMeni(tbNazivRest.Text);
            dgvMeni.DataSource = table.nazivi;
            if (table.nazivi.Rows.Count == 0)
            {
                MessageBox.Show("Ne postoji restoran sa takvom imenom. Proverite naziv restorana!");
                tbNazivRest.Clear();
            }
        }

        private void btnDostupnost_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm";
            string time = dateTimePicker3.Value.ToString("HH:mm");
            time += ":00";
            bool dostupno = DataProvider.ProveriDostupnost(tbNaziv.Text, date, time, tbBroj.Text);
            if (dostupno)
                label8.Text = "Dostupno: Da";
            else label8.Text = "Dostupno: Ne";
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm";
            string time = dateTimePicker3.Value.ToString("HH:mm");
            time += ":00";
            string brojRez;
            brojRez = DataProvider.Rezervisi(tbNaziv.Text, date, time, tbBroj.Text, tbIme.Text, tbPrezime.Text, tbTelefon.Text);
            if (brojRez != null)
                MessageBox.Show("Rezervacija uspesna. Broj vase rezervacije je " + brojRez);
            else
                MessageBox.Show("Niste uneli sve podatke!");
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (tbBrojRez.Text != "")
            {
                DataProvider.Otkazi(tbBrojRez.Text);
                MessageBox.Show("Uspesno ste otkazali rezervaciju!");
            }
            else
                MessageBox.Show("Unseite prvo broj vase rezervacije da biste je otkazali!");
        }
    }
}
