using System.Net.Http.Json;

namespace Challenge.Services
{
    public abstract class ServiceImpl<T> : IService<T>
    {

        private HttpClient Http;
        public ServiceImpl(HttpClient _http)
        {
            Http = _http;
        }
        
        public async Task<ServiceResponse> Add(T Entity)
        {
            var response = await Http.PostAsJsonAsync(GetUrl(), Entity);
            return new ServiceResponse() { IsSuccess = response.IsSuccessStatusCode, ErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult() } ;
        }

        public async Task<ServiceResponse> Delete(int Id)
        {
            var response = await Http.DeleteAsync(GetUrl() + "?Id=" + Id);
            return new ServiceResponse() { IsSuccess = response.IsSuccessStatusCode, ErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult() };
        }

        public async Task<List<T>?> Fetch()
        {
            return await Http.GetFromJsonAsync<List<T>>(GetUrl());
        }
        public async Task<ServiceResponse> Update(T Entity)
        {
            var response = await Http.PutAsJsonAsync(GetUrl(), Entity);
            return new ServiceResponse() { IsSuccess = response.IsSuccessStatusCode, ErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult() };
        }


        public abstract string GetUrl();


    }
}
