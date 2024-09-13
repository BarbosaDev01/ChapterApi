using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
      public class ChapterContext : DbContext
        {
            public ChapterContext()
            { }
            public ChapterContext(DbContextOptions<ChapterContext>
            options)
            : base(options)
            {
            }
           
         protected override void
           OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
            
                    optionsBuilder.UseSqlServer("Data Source = PC03LAB2517\\SENAI; initial catalog = Chapter; Integrated Security = true");
            }
            }
            // dbset representa as entidades que serão utilizadas 
             public DbSet<Livro> Livros { get; set; }
        }
    }

