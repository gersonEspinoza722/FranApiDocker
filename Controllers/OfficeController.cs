using FranApiDocker.Dtos;
using FranApiDocker.Services;

namespace FranApiDocker.Controllers
{
    public class OfficeController : GenericController<OfficeController, GetOfficeDto>
    {
        public OfficeController(IService<OfficeController, GetOfficeDto> service) : base(service)
        {
        }
    }
}