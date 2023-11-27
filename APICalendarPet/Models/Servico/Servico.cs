using System.ComponentModel.DataAnnotations;

namespace APICalendarPet.Models.Servico
{
    public class Servico
    {
        [Key]
        public int IDServico { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }

    }
}
