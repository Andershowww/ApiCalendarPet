using System.ComponentModel.DataAnnotations;

namespace APICalendarPet.Models.ServicoCategoria
{
    public class ServicoCategoria
    {
        [Key]
        public int IDServicoCategoria { get; set; }
        public string Nome { get; set; }
        public int IDServico { get; set; }
        public decimal Preco { get; set; }

        public decimal Custo { get; set; }

    }
}
