using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace FranApiDocker.Data

{
    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}