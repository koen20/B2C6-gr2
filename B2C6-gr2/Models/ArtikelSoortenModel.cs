using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2C6_gr2.Models
{
    public partial class ArtikelSoortenModel
    {
        public string ArtikelSoortNaam { get; set; }
        [Key]
        public int ArtikelSoortId { get; set; }
    }
}
