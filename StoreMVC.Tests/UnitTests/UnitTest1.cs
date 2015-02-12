using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreMVC.Models;

namespace StoreMVC.Tests.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
        }

        [TestMethod]
        public void Can_Generate_Page_Links()
        {
            HtmlHelper myHelper = null;
            PagingInfo pagingInfo = new PagingInfo()
            {
                CurrentPage = 2, TotalItems = 28, ItemsPerPage = 1
            };

            Func<int, string> pageUrlDelegate = i => "Page" + 1;
        }
    }
}
