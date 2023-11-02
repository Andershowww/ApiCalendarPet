using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APICalendarPet;

namespace Models
{
    public class Login
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
