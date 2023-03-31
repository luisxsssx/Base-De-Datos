using Microsoft.EntityFrameworkCore;

namespace DispensarioMedico;

public class SqliDBContext : DbContext
{
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<Medicamento> Medicamentos { get; set; }
    public DbSet<Receta> Recetas { get; set; }
    public DbSet<RecetaMedicamento> RecetaMedicamentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Db/dispensario.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecetaMedicamento>().HasKey(rm => new { rm.RecetaId, rm.MedicamentoId });
        base.OnModelCreating(modelBuilder);
    }
}