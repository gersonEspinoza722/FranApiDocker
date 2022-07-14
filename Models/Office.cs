using System.ComponentModel.DataAnnotations;

namespace FranApiDocker.Models
{
    public class Office
    {
        [KeyAttribute]
        public int id {get;set;}
        public int officeNumber {get;set;}
    }
}