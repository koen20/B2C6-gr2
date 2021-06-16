using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using B2C6_gr2.Data;
using B2C6_gr2.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace B2C6_gr2.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly B2C6_gr2Context _context;
        private IHostingEnvironment Environment;

        public ArticlesController(B2C6_gr2Context context, IHostingEnvironment _environment)
        {
            _context = context;
            Environment = _environment;
        }

        // GET: Articles
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["searchString"] = searchString;

            var articles = from s in _context.Artikelen
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.ArtikelNaam.Contains(searchString));
            }

            ViewData["filePaths"] = Directory.GetFiles(Path.Combine(this.Environment.WebRootPath, "Images/"));
            switch (sortOrder) {
                case "name_desc":
                    articles = articles.OrderByDescending(s => s.ArtikelNaam);
                    break;
                case "points":
                    articles = articles.OrderBy(s => s.ArtikelPunten);
                    break;
                default:
                    articles = articles.OrderByDescending(s => s.ArtikelNaam);
                    break;
            }
            return View(articles);
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Artikelen
                .FirstOrDefaultAsync(m => m.ArtikelId == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }
    }
}
