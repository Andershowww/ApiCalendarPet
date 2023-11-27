using APICalendarPet;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace APICalendarPet.API
{
    public class APIDataContext : DbContext

    {

        public APIDataContext(DbContextOptions<APIDataContext> options) : base(options) { }

        public DbSet<Models.Users.Users> User { get; set; }
        public DbSet<Models.Agenda> Agenda { get; set; }
        public DbSet<Models.Servico.Servico> Servico { get; set; }
        public DbSet<Models.ServicoCategoria.ServicoCategoria> ServicoCategoria { get; set; }
        public DbSet<Models.Animal.Animal> Animal { get; set; }
        // Adicione DbSet para outras tabelas conforme necessário
    }
}
