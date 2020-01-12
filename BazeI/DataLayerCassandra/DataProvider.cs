using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Data.Linq;
using DataLayerCassandra.CassandraEntities;

namespace DataLayerCassandra
{
    public static class DataProvider
    { 
    #region Prikazi Restorane
        public static string VratiPostanski(string naziv)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            string postanski = null;
            var nazivi = session.Execute("select postanskibroj from \"Grad\" where naziv = '" + naziv + "' allow filtering");
            foreach (var id in nazivi)
            {
                postanski = id["postanskibroj"] != null ? id["postanskibroj"].ToString() : string.Empty;
            }
            return postanski;
        }
        public static Table PrikaziRestorane(string grad, string tip, string vegan, string gluten)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            List<Restoran> restorani = new List<Restoran>();
            List<string> id = new List<string>();
            string postanski = VratiPostanski(grad);
            Table table = new Table();
            DataRow row;
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Naziv";
            table.nazivi.Columns.Add(column);

            var dataRestorani = session.Execute("select naziv from \"Restoran\" where postanski = '" + postanski + "' and tipkuhinje = '" + tip + "' and vegan = '" + vegan + "' and bezglutena = '" + gluten + "' allow filtering");
            foreach (var rd in dataRestorani)
            {
                row = table.nazivi.NewRow();
                row["Naziv"] = rd["naziv"] != null ? rd["naziv"].ToString() : string.Empty;
                table.nazivi.Rows.Add(row);
            }

            return table;
        }
        #endregion
        #region Prikazi Meni
        public static string RestoranId(string naziv)
        {
            string restoranid = null;
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            var restID = session.Execute("select \"restoranID\" from \"Restoran\" where naziv = '" + naziv + "' allow filtering");
            foreach (var id in restID)
            {
                restoranid = id["restoranID"] != null ? id["restoranID"].ToString() : string.Empty;
            }
            return restoranid;
        }
        public static Table PrikaziMeni(string naziv)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            Table table = new Table();
            DataRow row;
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Naziv";
            table.nazivi.Columns.Add(column);
            DataColumn column1 = new DataColumn();
            column1.ColumnName = "Sastojci";
            column1.DataType = System.Type.GetType("System.String");
            table.nazivi.Columns.Add(column1);
            DataColumn column2 = new DataColumn();
            column2.ColumnName = "Cena";
            column2.DataType = System.Type.GetType("System.String");
            table.nazivi.Columns.Add(column2);
            string restID = RestoranId(naziv);
            if (restID != null)
            {
                var jela = session.Execute("select * from \"Jelo\" where \"restoranID\" = '" + restID + "' allow filtering");
                foreach (var j in jela)
                {
                    Jelo jelo = new Jelo();
                    jelo.restoranID = restID;
                    jelo.jeloID = j["jeloID"] != null ? j["jeloID"].ToString() : string.Empty;
                    jelo.naziv = j["naziv"] != null ? j["naziv"].ToString() : string.Empty;
                    jelo.sastojci = j["sastojci"] != null ? j["sastojci"].ToString() : string.Empty;
                    jelo.cena = j["cena"] != null ? j["cena"].ToString() : string.Empty;
                    row = table.nazivi.NewRow();
                    row["Naziv"] = jelo.naziv;
                    row["Sastojci"] = jelo.sastojci;
                    row["Cena"] = jelo.cena;
                    table.nazivi.Rows.Add(row);
                }
            }
            return table;
        }
        #endregion
        public static bool ProveriDostupnost(string naziv, string datum, string vreme, string brojOsoba)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return false;
            List<string> stolovi = new List<string>();
            List<Rezervacija> rezervacijee = new List<Rezervacija>();
            string idstr = null;
            string restID = RestoranId(naziv);
            if (restID != null)
            {
                var stoloviId = session.Execute("select \"stoID\" from \"Sto\" where \"restoranID\" ='" + restID + "' and kapacitet >= '" + brojOsoba + "' allow filtering");
                foreach (var id in stoloviId)
                {
                    idstr = id["stoID"] != null ? id["stoID"].ToString() : string.Empty;
                    stolovi.Add(idstr);
                }
                foreach (string id in stolovi)
                {
                    var rezervacije = session.Execute("select * from \"Rezervacija\" where vreme = '" + vreme + "' and datum = '" + datum + "' and \"restoranID\" = '" + restID + "' and \"stoID\" = '" + id + "' allow filtering");
                    foreach (var r in rezervacije)
                    {
                        Rezervacija rezervacija = new Rezervacija();
                        rezervacija.rezervacijaID = r["rezervacijaID"] != null ? r["rezervacijaID"].ToString() : string.Empty;
                        rezervacija.vreme = vreme;
                        rezervacija.datum = datum;
                        rezervacija.restoranID = restID;
                        rezervacija.stoID = id;
                        rezervacijee.Add(rezervacija);
                    }
                }
            }
                if (stolovi.Count == rezervacijee.Count)
                    return false;
                else return true;
            
        }
        #region Dostupnost

        #endregion
        #region Rezervacija
        public static string Rezervisi(string naziv, string datum, string vreme, string brojOsoba, string ime, string prezime, string telefon)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            return null;
            int rezID = 0;
            string rezervacijaID = null;
            Rezervacija rr = new Rezervacija();
            string brojRez;
            bool dostupno = ProveriDostupnost(naziv, datum, vreme, brojOsoba);
            string restID = RestoranId(naziv);
            List<Gost> gosti1 = new List<Gost>();
            List<Rezervacija> rezervacije1 = new List<Rezervacija>();
            string stoID = VratiSto(brojOsoba, naziv);
            if (telefon != "")
            {
                var gosti = session.Execute("select * from \"Gost\" where telefon = '" + telefon + "'");
                foreach (var g in gosti)
                {
                    Gost gost = new Gost();
                    gost.ime = g["ime"] != null ? g["ime"].ToString() : string.Empty;
                    gost.prezime = g["prezime"] != null ? g["prezime"].ToString() : string.Empty;
                    gost.telefon = g["telefon"] != null ? g["telefon"].ToString() : string.Empty;
                    gosti1.Add(gost);
                }
            }
            int brGostiju = gosti1.Count;
            if(dostupno)
            {
                var rezervacije = session.Execute("select * from \"Rezervacija\"");
                foreach(var r in rezervacije)
                {
                    Rezervacija rez = new Rezervacija();
                    rez.rezervacijaID = r["rezervacijaID"] != null ? r["rezervacijaID"].ToString() : string.Empty;
                    rez.vreme = vreme;
                    rez.datum = datum;
                    rez.restoranID = restID;
                    rez.stoID = r["stoID"] != null ? r["stoID"].ToString() : string.Empty;
                    rezervacije1.Add(rez);
                }
                if(rezervacije1.Count > 0)
                    rr = rezervacije1.First();
                brojRez = rr.rezervacijaID;
                rezID = Convert.ToInt32(brojRez);
                rezID++;
                rezervacijaID = rezID.ToString();
                RowSet rezervacija = session.Execute("insert into \"Rezervacija\"(\"rezervacijaID\", vreme, datum, \"restoranID\", \"stoID\", gost, brojOsoba) values ('" + rezervacijaID + "', '" + vreme + "', '" + datum + "', '" + restID + "', '" + stoID + "', '" + telefon + "', '" + brojOsoba + "')");
                if (brGostiju != 1)
                {
                    RowSet novGost = session.Execute("insert into \"Gost\"(ime, prezime, telefon) values ('" + ime + "', '" + prezime + "', '" + telefon + "')");
                }
            }
            return rezervacijaID;
        }
        public static string VratiSto(string brojOsoba, string naziv)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;
            string restID = RestoranId(naziv);
            string id = null;
            List<string> stolovi = new List<string>();
            List<string> rezervisani = new List<string>();
            if (brojOsoba != "" || naziv != "")
            {
                var stoloviId = session.Execute("select \"stoID\" from \"Sto\" where kapacitet >= '" + brojOsoba + "' and \"restoranID\" = '" + restID + "' allow filtering");
                foreach (var s in stoloviId)
                {
                    string sto = s["stoID"] != null ? s["stoID"].ToString() : string.Empty;
                    stolovi.Add(sto);
                }
                var rezervisaniId = session.Execute("select \"stoID\" from \"Rezervacija\" where \"restoranID\" = '" + restID + "' allow filtering");
                foreach (var r in rezervisaniId)
                {
                    string sto = r["stoID"] != null ? r["stoID"].ToString() : string.Empty;
                    rezervisani.Add(sto);
                }
                foreach (string sto in stolovi)
                {
                    foreach (string rez in rezervisani)
                    {
                        if (sto != rez)
                            id = sto.ToString();
                    }
                }

                return id;
            }
            else
            { return null; }
        }
        #endregion
        #region Otkazi Rezervaciju
        public static void Otkazi(string broj)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return;
            RowSet otkazi = session.Execute("delete from \"Rezervacija\" where \"rezervacijaID\" = '" + broj + "'");
        }
        #endregion
    }
    public class Table
    {
        public DataTable nazivi;

        public Table()
        {
            nazivi = new DataTable("Restorani");
        }
    }
}
