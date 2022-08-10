namespace ProyectoEmcartago.Client.Repositorios.RepositorioPEDSYP
{
    public interface IRepositorioPEDSYP
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        List<PEDSYP> Funcionarios { get; set; }
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}
