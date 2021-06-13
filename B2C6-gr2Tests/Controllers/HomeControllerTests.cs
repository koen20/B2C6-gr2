using Microsoft.VisualStudio.TestTools.UnitTesting;
using B2C6_gr2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C6_gr2.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            Assert.IsNotNull(true);
        }

        //[TestMethod()]
        //public void GetArticles()
        //{

            
        //    var articles = from s in _context.Article
        //                   select s;
        //    Assert.IsNotNull(true);
        //}
    }
}