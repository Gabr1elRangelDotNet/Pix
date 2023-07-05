using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options): base(options) 
        { 

        }

        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Chave> Chaves { get; set; }
        public DbSet<Recebedor>  Pagadores{ get; set; }
        public DbSet<Pagador>  Recebedores{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
