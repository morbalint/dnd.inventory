using AutoMapper;

namespace dnd.inventory.api.Profiles
{
    /// <summary>
    /// Default profile for AutoMapper
    /// </summary>
    /// <remarks>See: https://github.com/drwatson1/AspNet-Core-REST-Service/wiki#automapper</remarks>
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Model.Item, Dto.Product>();
            CreateMap<Dto.UpdateProduct, Model.Item>();
            // For copy creation
            CreateMap<Model.Item, Model.Item>();
        }
    }
}
