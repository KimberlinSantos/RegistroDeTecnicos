using Microsoft.EntityFrameworkCore;
using RegistroTecnicos.Models;
namespace RegistroTecnicos.DAL;

public class Contexto : DbContext
{

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }
    public DbSet<Tecnicos> Tecnicos { get; set; }
    public DbSet<TiposTecnicos> TiposTecnicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tecnicos>()
           .HasOne(tt => tt.TipoTecnico)
           .WithMany(t => t.Tecnicos)
           .HasForeignKey(t => t.TipoTecnicoId);

        modelBuilder.Entity<TiposTecnicos>()
            .Property(tt => tt.Incentivo)
            .HasDefaultValue(0);




        base.OnModelCreating(modelBuilder);
    }

}