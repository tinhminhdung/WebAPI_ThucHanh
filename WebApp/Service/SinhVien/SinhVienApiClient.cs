using Application.MSinhVien;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service
{
	public class SinhVienApiClient : ISinhVienApiClient
	{
		private readonly IHttpClientFactory _httpClientFactory;
		string Url = "https://localhost:44325";
		public SinhVienApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<string> Create(SinhVienViewModel request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(Url);
			var response = await client.PostAsync("api/SinhVien/Create", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Update(SinhVienViewModel request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(Url);
			var response = await client.PostAsync("api/SinhVien/Update", httpContent);

			return await response.Content.ReadAsStringAsync();
		}
		public async Task<string> GetAll()
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(Url);
			var response = await client.GetAsync("api/SinhVien/Get");

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetById(int id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(Url);
			var response = await client.GetAsync("api/SinhVien/GetById/" + id + "");

			return await response.Content.ReadAsStringAsync();
		}
		public async Task<string> Delete(int id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(Url);
			var response = await client.GetAsync("api/SinhVien/Delete/" + id + "");

			return await response.Content.ReadAsStringAsync();
		}
		

	}
}
