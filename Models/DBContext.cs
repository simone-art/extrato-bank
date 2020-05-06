using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ExtratoBank.Models
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = "";

            try
            {
                config = ConfigurationManager.ConnectionStrings["web"].ConnectionString;
            }
            catch
            {
                config = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Extrato_Bank;Data Source=USER-VAIO";
            }
            optionsBuilder.UseSqlServer(config);
        }
        public DbSet<ExtratoBankCliente> ExtratoBankClientes { get; set; }
    }
}
