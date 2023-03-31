using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DispensarioMedico;

public class Doctor
{
    public int Id { get; set; }
    [Required,MaxLength(50)]
    public string Nombres { get; set; }
    [Required,MaxLength(50)]
    public string Apellidos { get; set; }
    [Required,MaxLength(20)]
    public string CedulaProfesional { get; set; }
    [Required,MaxLength(100)]
    public string Especialidad { get; set; }
    [NotMapped]
    public string NombreCompleto 
    { 
        get{return$"{Nombres} {Apellidos}";} 
    }
}