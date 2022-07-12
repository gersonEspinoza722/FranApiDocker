using FranApiDocker.Services;
using Microsoft.AspNetCore.Mvc;

namespace FranApiDocker.Controllers
{
    public class GenericController<TEntity, TDto> : ControllerBase
    where TEntity : class

    {
        private readonly IService<TEntity, TDto> _service;
                
    }
}