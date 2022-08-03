namespace ProyectoEmcartago.Client.Repositorios.RepositorioUsoEpp
{
    public interface IRepositorioUsoEpp
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        List<InspeccionUsoEpp> Funcionarios { get; set; }
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task Put(InspeccionUsoEpp funcionario);
    }
}
