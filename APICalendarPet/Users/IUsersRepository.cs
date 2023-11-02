using Models;
namespace APICalendarPet.Users
{

    public interface IUsersRepository
    {
        Task<List<Models.Users>> GetUsuarios(int id_Empresa);
        Task<List<Models.Users>> ValidaUsuario(string CPF, string Senha);
    }
}

