using System.ComponentModel.DataAnnotations;

namespace L01P022023LG651.Models
{
    public class Materia
    {
        [Key]
        public int id { get; set; }

        public string materia { get; set; }

        public int unidades_valorativas { get; set; }

        public char estado { get; set; }
    }
}