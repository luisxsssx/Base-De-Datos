using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DispensarioMedico;

public class Receta{
    public int Id { get; set; }
    public int ConsultaId { get; set; }
    [Required, MaxLength(100)]
    public string Dosis { get; set; }
}