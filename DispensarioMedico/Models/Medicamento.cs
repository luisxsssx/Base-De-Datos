using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DispensarioMedico;

public class Medicamento
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string Nombre { get; set; }
    [Required]
    public Presentacion Presentacion { get; set; }
    [Required, MaxLength(20)]
    public string Cantidad { get; set; }
}

public enum Presentacion
{
    Tableta, Jarabe, Inyeccion, Supositorio, Gotas, Parche
}