namespace ProyectoEmcartago.Client.Repositorios.RepositorioIngresoySalida
{
    public class RepositorioIngresoySalida : IRepositorioIngresoySalida
    {
        private readonly HttpClient httpClient;
        private readonly HttpClient http;
        private readonly NavigationManager NavigationManager;

        public RepositorioIngresoySalida(HttpClient _httpClient, HttpClient _http, NavigationManager _NavigationManager)
        {
            httpClient = _httpClient;
            http = _http;
            NavigationManager = _NavigationManager;
        }

        public List<IngresoySalida> IngresoySalidaEquiposComputo { get; set; } = new List<IngresoySalida>();

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);

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

        public async Task Post(IngresoySalida IngresoySalidaEquiposComputo)
        {
            var result = await httpClient.PostAsJsonAsync("api/IngresoySalidaComputo", IngresoySalidaEquiposComputo);
            await SetFuncionario(result);
        }
        private async Task SetFuncionario(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<IngresoySalida>>();
            NavigationManager.NavigateTo("registros-ec");
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await http.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }


        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
    }
}
