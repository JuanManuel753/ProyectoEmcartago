using AutoMapper;
using ProyectoEmcartago.Shared.Entidades.Entidad_Formato_Entrega_Epp;

namespace ProyectoEmcartago.Server.Almacenador
{
    public class AutoMapperPerfiles : Profile
    {
        public AutoMapperPerfiles()
        {
            CreateMap<FormatoEntregaEpp, FormatoEntregaEpp>()
                .ForMember(x => x.Foto, option => option.Ignore());
        }
    }
}
