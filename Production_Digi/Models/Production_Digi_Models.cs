using System.ComponentModel.DataAnnotations;

namespace Production_Digi.Models
{
    public class Campo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

    }
    public class Registro
    {
        [Key]

        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public int CampoId { get; set; }

        public Campo Campo { get; set; }
        public double valor { get; set; }
    }


}
