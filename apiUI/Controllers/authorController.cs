using apiUI.Models.author;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using System.Text;

namespace apiUI.Controllers
{
    public class authorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public authorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:44334/api/author");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var datas = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<authorModelView>>(datas);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult addAuthor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> addAuthor(addAuthorModelView model)
        {
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var ResponseMessage = await client.PostAsync("https://localhost:44334/api/author", content);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
