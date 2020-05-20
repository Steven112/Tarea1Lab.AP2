using Microsoft.EntityFrameworkCore;
using RegistroOneAP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOneAP2.Data
{
    public class Contexto: DbContext
    {
        public DbSet<Usuario>Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\UsuarioControl.db");
        }
        
    }
}
