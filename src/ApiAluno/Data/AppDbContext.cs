using Microsoft.EntityFrameworkCore;
using ApiAluno.Models;

namespace ApiAluno.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
            { 
            }

        public DbSet<Aluno> Alunos { get; set; }
    }
}