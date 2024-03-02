using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class EmployeeTestController : Controller
	{
		public async Task<IActionResult> Index()
		{
			// apiler ile kuullanma mvc de  ÖNEMLİ !!!
			var httpclient = new HttpClient();
			var responsemessage = await httpclient.GetAsync("https://localhost:44385/api/Default");
			var jsonString = await responsemessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
			return View(values);
		}
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        //Deserialize ; JSON verilerini.Net nesnesine dönüştürmeye yarar
        // Serialize ; .Net nesnesini JSON verisine dönüştürmeye yarar.
 

         [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient = new HttpClient(); // ÖNCE BİR DEGER AL 
            var jsonEmployee = JsonConvert.SerializeObject(p); //  parametreden gelen degerlerı serialize et
            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json"); // content icerigi, encoding türü, media type  3 parametre
            var rensonseMessage = await httpClient.PostAsync("https://localhost:44385/api/Default", content);
            if (rensonseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44385/api/Default/" + id); 
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonEmployee = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonEmployee);
                return View(values);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44385/api/Default/" + p.ID, content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44385/api/Default/" + id); 
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
    public class Class1 
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}
}
