using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2C6_gr2.Models
{
    public partial class Artikelen
    {
        [Key]
        public int ArtikelId { get; set; }
        public string ArtikelNaam { get; set; }
        public int ArtikelSoortId { get; set; }
        public int ArtikelPunten { get; set; }
        public string Serienummer { get; set; }
    }
}
