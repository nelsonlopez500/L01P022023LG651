using System.ComponentModel.DataAnnotations;

namespace L01P022023LG651.Models
{
    public class Departamento
    {
        [Key]
        public int id { get; set; }

        public string departamento { get; set; }
    }
}