namespace ProyectoEmcartago.Client.Repositorios.RepositorioUsoEpp
{
    public class RepositorioUsoEpp : IRepositorioUsoEpp
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public RepositorioUsoEpp(HttpClient httpClient, HttpClient http, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<InspeccionUsoEpp> Funcionarios { get; set; } = new List<InspeccionUsoEpp>();

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await _httpClient.GetAsync(url);

            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _http.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task Put(InspeccionUsoEpp funcionario)
        {
            var result = await _http.PutAsJsonAsync($"api/usoepp/{funcionario.Id}", funcionario);
            await SetFuncionarios(result);
        }
        private async Task SetFuncionarios(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<InspeccionUsoEpp>>();
            Funcionarios = response;
            _navigationManager.NavigateTo("indiceusoepp");
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
    }
}
