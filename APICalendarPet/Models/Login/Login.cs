using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APICalendarPet;

namespace APICalendarPet.Models.Login
{
    public class Login
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
