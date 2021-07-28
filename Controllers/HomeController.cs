using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Store.Teste.Controllers
{
    public class HomeController : Controller

    {
        // localhost:xxx

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Sobre()
        {
            return View();
        }



    }
}
