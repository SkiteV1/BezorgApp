//using BezorgApp.MVVM.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Json;
//using System.Text;
//using System.Threading.Tasks;

//namespace BezorgApp.Data
//{
//    public class ApiClient 
//    { 
//        private readonly HttpClient _httpClient;
//        public ApiClient(HttpClient httpClient) 
//        { 
//            _httpClient = new HttpClient();
//            _httpClient.BaseAddress = new System.Uri(httpClient.ApiBaseAddress);
//        } 
//        public async Task<List<Order>?> GetOrders()
//        {
//            return await _httpClient.GetFromJsonAsync<List<Order>?>("/api/Order");
//        } 

//        public async Task<Order?> GetById(int id)
//        {
//            return await _httpClient.GetFromJsonAsync<Order?>($"/api/Order/{id}");
//        }

//        public  async Task SaveOrder(Order order)
//        {
//            await _httpClient.PostAsJsonAsync("/api/Order", order);
//        }

//        public async Task UpdateOrder(Order order)
//        {
//            await _httpClient.PutAsJsonAsync("/api/Order", order);
//        }

//        public async Task DeleteOrder(int id)
//        {
//            await _httpClient.DeleteAsync($"/api/Order/{id}");
//        }
//    }
//}
