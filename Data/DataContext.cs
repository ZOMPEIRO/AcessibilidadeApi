using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabalhoTCC.Models;

namespace TrabalhoTCC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Acessibilidade> TB_ACESSIBILIDADE { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acessibilidade>().ToTable("TB_ACESSIBILIDADE");

            modelBuilder.Entity<Acessibilidade>().HasData
            (
                new Acessibilidade() { idAcessibilidade = 1, idUsuario = 1, modoContraste = true, tamanhoFonte = "45", alertaSonoro = false, vibração = true },
                new Acessibilidade() { idAcessibilidade = 2, idUsuario = 2, modoContraste = true, tamanhoFonte = "45", alertaSonoro = true, vibração = true },
                new Acessibilidade() { idAcessibilidade = 3, idUsuario = 3, modoContraste = false, tamanhoFonte = "45", alertaSonoro = true, vibração = true },
                new Acessibilidade() { idAcessibilidade = 4, idUsuario = 4, modoContraste = false, tamanhoFonte = "45", alertaSonoro = true, vibração = false },
                new Acessibilidade() { idAcessibilidade = 5, idUsuario = 5, modoContraste = false, tamanhoFonte = "45", alertaSonoro = true, vibração = false },
                new Acessibilidade() { idAcessibilidade = 6, idUsuario = 6, modoContraste = false, tamanhoFonte = "45", alertaSonoro = true, vibração = true },
                new Acessibilidade() { idAcessibilidade = 7, idUsuario = 7, modoContraste = true, tamanhoFonte = "45", alertaSonoro = true, vibração = false }

            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }

    }
}