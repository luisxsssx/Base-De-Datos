using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DispensarioMedico;

public class Consulta
{
    public int Id { get; set; }
    [Required]
    public System.DateTime FechaConsulta { get; set; }
    [Required]
    public int PacienteId { get; set; }
    [Required]
    public int DoctorId { get; set; }
    [Required]
    public double Temperatura { get; set; }
    [Required]
    public double Oxigenacion { get; set; }
    [Required]
    public double Peso { get; set; }
    [Required]
    public double Estatura { get; set; }
    [Required]
    public string Presion { get; set; }
    [Required, MaxLength(500)]
    public string Sintomas { get; set; }
    [Required, MaxLength(500)]
    public string Diagnostico { get; set; }
}