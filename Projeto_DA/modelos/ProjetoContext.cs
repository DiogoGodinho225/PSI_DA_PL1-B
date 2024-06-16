using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto_DA.modelos;


namespace Projeto_DA
{

    public class ProjetoContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Estudante> Estudante { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Professor> Professor { get; set;}
        public DbSet<Utilizador> Utilizador { get; set; }
        public DbSet<Extra> Extra { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<ItemFatura> ItemFatura { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Multa> Multa { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<QuantidadeExtra> QuantidadeExtra { get; set; }

        public DbSet<QuantidadePratos> QuantidadePratos { get; set; }


    }
}       