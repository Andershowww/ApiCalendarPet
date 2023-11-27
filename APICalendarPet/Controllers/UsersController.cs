using Microsoft.AspNetCore.Mvc;
using APICalendarPet.API;
using APICalendarPet;
using Microsoft.EntityFrameworkCore;
using APICalendarPet.Models;
using APICalendarPet.Users;

namespace APICalendarPet.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersRepository _usersRepository;
        public UsersController(IUsersRepository Users)
        {
            _usersRepository = Users;
        }

        //public UsersController(APIDataContext context)
        //{


        //}

        [HttpGet]
        public async Task<ActionResult<List<Models.Users.Users>>> GetUsuarios()
        {
            var usuarios = await _usersRepository.GetUsuarios(1);  // Usar _context.Users, não _context.User
            return usuarios;
        }
    }
}
