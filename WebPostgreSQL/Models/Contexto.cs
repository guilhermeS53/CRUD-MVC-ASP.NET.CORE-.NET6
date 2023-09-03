﻿using Microsoft.EntityFrameworkCore;

namespace WebPostgreSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto() { 
            
        }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { 
            
        }

        public DbSet<Produto> Produtos { get; set; }    

    }
}
