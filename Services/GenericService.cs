using System.Collections.Generic;
using FranApiDocker.Data;

namespace FranApiDocker.Services
{
    public class GenericService<TEntity, TDto> : IService<TEntity, TDto> 
    where TEntity : class
    {
        private readonly DataContext _context;

        public System.Threading.Tasks.Task<ServiceResponse<List<TDto>>> Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<ServiceResponse<List<TDto>>> Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<ServiceResponse<List<TDto>>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<ServiceResponse<TDto>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<ServiceResponse<TDto>> Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}