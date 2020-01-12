using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerCassandra.CassandraEntities
{
    public class Rezervacija
    {
        public string rezervacijaID { get; set; }
        public string vreme { get; set; }
        public string datum { get; set; }
        public string restoranID { get; set; }
        public string stoID { get; set; }
    }
}
