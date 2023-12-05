using APICalendarPet;
using System.ComponentModel.DataAnnotations;

namespace APICalendarPet.Models.Agenda
{
    public class Agenda
    {
        [Key]
        public int AgendaID { get; set; }
        public int IDAnimal { get; set; }
        public int IDHorario { get; set; }
        public bool AtualizadoSistema { get; set; }
        public int IDEmpresa { get; set; }
        public int IDServicoCategoria { get; set; }

    }
}
