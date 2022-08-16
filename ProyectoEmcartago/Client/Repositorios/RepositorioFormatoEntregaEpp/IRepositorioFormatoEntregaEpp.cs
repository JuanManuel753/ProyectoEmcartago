namespace ProyectoEmcartago.Client.Repositorios.RepositorioFormatoEntregaEpp
{
    public interface IRepositorioFormatoEntregaEpp
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}
