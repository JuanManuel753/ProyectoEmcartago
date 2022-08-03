namespace ProyectoEmcartago.Client.Mensajes.Alertas
{
    public class MostrarAlertaError
    {
        public static Dictionary<string, object> Param(string mensaje)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();

            param.Add("title", "Error");
            param.Add("icon", "error");
            param.Add("text", mensaje);
            param.Add("showConfirmButton", true);


            return param;
        }
    }
}
