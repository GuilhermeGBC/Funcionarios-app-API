using API.Funcionarios.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Funcionarios.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
