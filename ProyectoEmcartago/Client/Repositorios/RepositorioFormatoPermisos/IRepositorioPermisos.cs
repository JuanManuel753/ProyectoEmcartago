namespace ProyectoEmcartago.Client.Repositorios.RepositorioFormatoPermisos
{
    public interface IRepositorioPermisos
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        List<FormatoPermisos> Funcionarios { get; set; }
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}
