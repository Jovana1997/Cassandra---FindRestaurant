using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerCassandra.CassandraEntities
{
    public class Restoran
    {
        public string postanskiBroj { get; set; }
        public string restoranID { get; set; }
        public string grad { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string brojStolova { get; set; }
        public string tipKuhinje { get; set; }
        public string vegan { get; set; }
        public string bezGlutena { get; set; }
    }
}
