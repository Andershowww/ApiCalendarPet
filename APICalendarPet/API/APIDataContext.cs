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

        public DbSet<Models.Users> User { get; set; }
        // Adicione DbSet para outras tabelas conforme necessário
    }
}
