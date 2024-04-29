using EShop.Domain.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        public async Task<ActionResult> Index()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:5054/api/admin");

            string responseBody = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON into the C# object using Newtonsoft.Json
            var myObject = JsonConvert.DeserializeObject<List<Order>>(responseBody);

            return View(myObject);
        }


        // GET: AdminController/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:5054/api/admin");

            string responseBody = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON into the C# object using Newtonsoft.Json
            var myObject = JsonConvert.DeserializeObject<List<Order>>(responseBody);

            return View(myObject.First(o => o.Id == id));
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
