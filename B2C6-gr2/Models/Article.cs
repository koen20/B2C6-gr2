using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2C6_gr2.Models
{
    public class Article
    {
        public int Id { get; set; }
        public String ArtikelNaam { get; set; }
        public int ArtikelSoortId { get; set; }
        public int ArtikelPunten { get; set; }
        public String Serienummer { get; set; }
    }
}
