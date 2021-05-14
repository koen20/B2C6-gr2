using Microsoft.VisualStudio.TestTools.UnitTesting;
using B2C6_gr2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2C6_gr2.Models;

namespace B2C6_gr2.Controllers.Tests
{
    [TestClass()]
    public class ArticlesControllerTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            ArticlesController articlesController = new ArticlesController();
            Assert.IsNotNull(articlesController.Index());
        }
    }
}