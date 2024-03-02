using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
	public class Statistic1 : ViewComponent
	{
		BlogManager bm = new BlogManager(new EFBlogRepository());
		Context c = new Context();
		public async Task<IViewComponentResult> InvokeAsync()
		{
			ViewBag.v1 = bm.GetList().Count();
			ViewBag.v2 = c.Contacts.Count();
			ViewBag.v3 = c.Comments.Count();

			// rapid api kullanımı   api key oluştur + baglantı adresini al 
			string api = "038d31dc3b05b86d7673f78b15ddf47c";
			string city = "Istanbul";
			string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={api}";

			using (var httpClient = new HttpClient())
			{
				HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string jsonResponse = await response.Content.ReadAsStringAsync();
					JObject jsonData = JObject.Parse(jsonResponse);

					// Kelvin'den santigrata dönüşüm
					double temperatureKelvin = (double)jsonData["main"]["temp"];
					double temperatureCelsius = temperatureKelvin - 273.15;

					double roundedTemperature = Math.Round(temperatureCelsius, 1);

					ViewBag.v4 = roundedTemperature;

				}
				else
				{
					ViewBag.v4 = "Error";
				}
			}

			return View();

			}
		}
	}
