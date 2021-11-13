using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp2
{
    [Table(Name = "klient")]
    class kl
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_klienta")]
        public int id_klienta { get; set; }
        [Column]
        public  string fname { get; set; }
        [Column]
        public string name { get; set; }
        [Column]
        public string otchestvo { get; set; }
        [Column]
        public string adres { get; set; }
        [Column]
        public int telefon { get; set; }
    }
}
