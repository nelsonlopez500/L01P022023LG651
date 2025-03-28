using System.ComponentModel.DataAnnotations;

namespace L01P022023LG651.Models
{
    public class Facultad
    {
        [Key]
        public int id { get; set; }

        public string facultad { get; set; }
    }
}