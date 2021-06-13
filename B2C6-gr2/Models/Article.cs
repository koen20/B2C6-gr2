using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2C6_gr2.Models
{
    [Table("Artikelen")]
    public class Article
    {
        [Column("ArtikelId")]
        public int Id { get; set; }
        public String ArtikelNaam { get; set; }
        [Column("ArtikelSoortID")]
        public int ArtikelSoortId { get; set; }
        public int ArtikelPunten { get; set; }
        public String Serienummer { get; set; }
    }
}
