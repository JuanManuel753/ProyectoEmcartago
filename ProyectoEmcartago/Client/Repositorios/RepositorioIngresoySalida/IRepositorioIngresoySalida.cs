namespace ProyectoEmcartago.Client.Repositorios.RepositorioIngresoySalida
{
    public interface IRepositorioIngresoySalida
    {
        List<IngresoySalida> IngresoySalidaEquiposComputo { get; set; }
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task Post(IngresoySalida IngresoySalidaEquiposComputo);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}
