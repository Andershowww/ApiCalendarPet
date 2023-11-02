using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APICalendarPet;

namespace Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int IDUser { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public int IDEmpresa { get; set; }

    }
}

