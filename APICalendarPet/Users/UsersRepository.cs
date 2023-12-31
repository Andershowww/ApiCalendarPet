﻿using APICalendarPet;
using APICalendarPet.API;
using Microsoft.EntityFrameworkCore;
using APICalendarPet.Models;

namespace APICalendarPet.Users
{
    public class UsersRepository : IUsersRepository
    {
        private APIDataContext _context;

        //Carrega a connection string que aponta para o banco de dados
        public UsersRepository(APIDataContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Users.Users>> GetUsuarios(int id_empresa)
        {
            var queryClientes = _context.User.AsQueryable();
            queryClientes = queryClientes.Where(p => p.IDEmpresa == id_empresa);

            return await queryClientes.ToListAsync();
        }
        public async Task<List<Models.Users.Users>> ValidaUsuario(string CPF, string Senha)
        {
            
            var queryClientes = _context.User.AsQueryable();
            queryClientes = queryClientes.Where(p => p.CPF == CPF && p.Senha==Senha);

            return await queryClientes.ToListAsync();
        }
    }
}
