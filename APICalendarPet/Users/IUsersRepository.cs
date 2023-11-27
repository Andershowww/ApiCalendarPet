using APICalendarPet.Models;

namespace APICalendarPet.Users
{

    public interface IUsersRepository
    {
        Task<List<Models.Users.Users>> GetUsuarios(int id_Empresa);
        Task<List<Models.Users.Users>> ValidaUsuario(string CPF, string Senha);
    }
}

