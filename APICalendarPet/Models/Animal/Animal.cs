using System.ComponentModel.DataAnnotations;

namespace APICalendarPet.Models.Animal
{
    public class Animal
    {
        [Key]
        public int IDAnimal { get; set; }
        public string Nome { get; set; }
        public int IDRaca { get; set; }
        public int IDEspecie { get; set; }
        public int IDUser { get; set; }

    }
}
