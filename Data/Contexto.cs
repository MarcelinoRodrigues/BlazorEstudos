using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Contexto : DbContext
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="opcoes"></param>
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        //public DbSet<Curso>
    }
}
