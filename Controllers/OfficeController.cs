using FranApiDocker.Dtos;
using FranApiDocker.Models;
using FranApiDocker.Services;

namespace FranApiDocker.Controllers
{
    public class OfficeController : GenericController<Office, GetOfficeDto>
    {
        public OfficeController(IService<Office, GetOfficeDto> service) : base(service)
        {
        }
    }
}