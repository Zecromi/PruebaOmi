using GespaWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GespaWebAPI.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)//Aqui se crea la API
        {
            
        }
        public DbSet<Person> Persons { get; set; }//Otras clases pueden acceder aqui //get; set; | Permiso de Lectura y escritura para la base

    }
} 