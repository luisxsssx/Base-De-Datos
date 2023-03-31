using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DispensarioMedico;

public class Paciente
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Nombres { get; set; }
    [Required, MaxLength(50)]
    public string Apellidos { get; set; }
    [Required]
    public Genero Genero { get; set; }
    [Required, MaxLength(10)]
    public string TipoDeSangre { get; set; }
    [Required]
    public System.DateTime FechaDeNacimiento { get; set; }
    [MaxLength(100)]
    public string Alergias { get; set; }
    [NotMapped]
    public string NombreCompleto 
    {
    
        get{return$"{Nombres} {Apellidos}";}
        
    }
}

public enum Genero
{
    Masculino,
    Femenino
}