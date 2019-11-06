using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace _18.Test.Controllers
{
    public class TestController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
           return View();
        }

        // 
        // GET: //WelcomeHelloWorld/ 

        public IActionResult Welcome()
        {
            return View();
        }
    }
}