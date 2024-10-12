using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("Medicamento")]
public partial class Medicamento
{
    [Column("NOMBRE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("CONCENTRACION")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Concentracion { get; set; }

    [Column("PRECIO", TypeName = "decimal(18, 2)")]
    public decimal? Precio { get; set; }

    [Column("STOCK")]
    public int? Stock { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Key]
    [Column("IIDMEDICAMENTO")]
    public int Iidmedicamento { get; set; }

    [InverseProperty("IidmedicamentoNavigation")]
    public virtual ICollection<CitaMedicamento> CitaMedicamentos { get; set; } = new List<CitaMedicamento>();
}
