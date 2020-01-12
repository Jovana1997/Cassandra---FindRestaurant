using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerCassandra.CassandraEntities
{
    public class Jelo
    {
        public string restoranID { get; set; }
        public string jeloID { get; set; }
        public string naziv { get; set; }
        public string sastojci { get; set; }
        public string cena { get; set; }
    }
}
