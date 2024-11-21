using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Bibliotec.Contexts
{
    // Classe rque tera as informacoes do banco de dados
    public class Contexts : DbContext
    {
        public Contexts()
        {

        }

        public Contexts(DbContextOptions<Contexts> options) : base(options)
        {

        }

        // OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // As configuracoes elas existem
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-0DDHOMT\SQLEXPRESS;
                Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123;
                Integrated Security=true; TrustServerCertificate = true");
            }
        }
        // As referencias das nossas tabelas no banco de daodos:
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<LivroCategoria> LivroCategoria { get; set; }
        public DbSet<LivroReserva> LivroReserva { get; set; }
    }

    public class ContextsBoundObject
    {
    }
}