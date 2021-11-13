using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp2
{
    [Table(Name = "tovar")]
    class tov
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_tovar")]
        public int id_tovar { get; set; }
        [Column(Name = "nazvanie")]
        public string nazvanie { get; set; }
        [Column(Name = "tsena")]
        public decimal tsena { get; set; }
        [Column(Name = "ed_izm")]
        public string ed_izm { get; set; }
        [Column(Name = "kolvo")]
        public string kolvo{ get; set; }
    }
    [Table(Name = "prod")]
    class prod
    {
        [Column(Name = "id_prod")]
        public int id_prod { get; set; }
        [Column(Name = "id_tovar ")]
        public int id_tovar { get; set; }
        [Column(Name = "kolvo")]
        public string kolvo { get; set; }
    }
}
