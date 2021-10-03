using ApiPokemon.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPokemon.Controller.Data
{
    public class RepositoryPokemon : DbContext
    {
        public RepositoryPokemon(DbContextOptions<RepositoryPokemon> opt) : base(opt)
        {

        }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
