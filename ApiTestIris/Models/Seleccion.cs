using System.ComponentModel.DataAnnotations;

namespace ApiTestIris.Models
{
    public class Seleccion
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public string State { get; set; }

    }
}
