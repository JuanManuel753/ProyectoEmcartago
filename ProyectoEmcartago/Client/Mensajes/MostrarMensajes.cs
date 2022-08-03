namespace ProyectoEmcartago.Client.Mensajes
{
    public class MostrarMensajes : IMostrarMensajes
    {
        private readonly IJSRuntime _js;

        public MostrarMensajes(IJSRuntime js)
        {
            _js = js;
        }
        public async Task MostrarMensajeError(string mensaje)
        {
            await _js.InvokeVoidAsync("Swal.fire", MostrarAlertaError.Param(mensaje));
        }

        public async Task MostrarMensajeExitoso(string mensaje)
        {
            await _js.InvokeVoidAsync("Swal.fire", MostrarAlertaBuena.Param(mensaje));
        }
    }
}
