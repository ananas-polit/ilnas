using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp2
{
    [Table(Name = "prodazha")]
    class pr
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_prod")]
        public int id_prod { get; set; }
        [Column(Name = "id_client")]
        public int id_client { get; set; }
        [Column(Name = "data_prod")]
        public DateTime data_prod { get; set; }
    }
}
