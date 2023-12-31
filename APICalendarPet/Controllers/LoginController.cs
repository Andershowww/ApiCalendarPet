﻿using Microsoft.AspNetCore.Mvc;
using APICalendarPet.API;
using APICalendarPet;
using Microsoft.EntityFrameworkCore;
using APICalendarPet.Users;
using APICalendarPet.Models.Login;

[Route("api/v1/Login")]
[ApiController]
public class LoginController : ControllerBase
{
    private IUsersRepository _usersRepository;
    public LoginController(IUsersRepository Users)
    {
        _usersRepository = Users;
    }

    [HttpPost]
    public async Task<ActionResult<int>> ValidaUsuario([FromBody] Login login)
    {
        try { 
        string cpf = login.CPF.Replace(".","");
        cpf = cpf.Replace("-","");
        var usuarios = await _usersRepository.ValidaUsuario(cpf, login.Senha);  // Usar _context.Users, não _context.User
        if (usuarios != null && usuarios.Count>0)
            return usuarios.FirstOrDefault().IDUser;
        else
            return 0;
        }
        catch (Exception ex)
        {

        }
        return 0;
    }

}

