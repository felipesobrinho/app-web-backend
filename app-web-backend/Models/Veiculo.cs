using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{

    [Table("Veiculos")]

    public class Veiculo
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar um Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Placa")]
        public string Placa { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
