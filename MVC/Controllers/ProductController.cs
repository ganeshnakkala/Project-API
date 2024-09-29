using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApiRequest _apiRequest;

        public ProductController(ApiRequest apiRequest)
        {
            _apiRequest = apiRequest;
        }

        // GET: hello
        public async Task<IActionResult> Index()
        {
            // hello message from the API
            var helloMessage = await _apiRequest.GetHelloAsync();
            ViewBag.HelloMessage = helloMessage;
            return View();
        }

        // POST: hello + name
        [HttpPost]
        public async Task<IActionResult> GetPersonalizedHello(string name)
        {
            //  name+  hello message from the API
            var personalizedHello = await _apiRequest.GetPersonalizedHelloAsync(name);
            ViewBag.PersonalizedHelloMessage = personalizedHello;
            return View("Index");
        }
    }
}
