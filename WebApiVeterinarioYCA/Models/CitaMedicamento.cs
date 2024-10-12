using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("CitaMedicamento")]
public partial class CitaMedicamento
{
    [Key]
    [Column("IIDCITAMEDICAMENTO")]
    public int Iidcitamedicamento { get; set; }

    [Column("IIDCITA")]
    public int? Iidcita { get; set; }

    [Column("IIDMEDICAMENTO")]
    public int? Iidmedicamento { get; set; }

    [Column("PRECIO", TypeName = "decimal(18, 2)")]
    public decimal? Precio { get; set; }

    [Column("CANTIDAD")]
    public int? Cantidad { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [ForeignKey("Iidcita")]
    [InverseProperty("CitaMedicamentos")]
    public virtual Citum? IidcitaNavigation { get; set; }

    [ForeignKey("Iidmedicamento")]
    [InverseProperty("CitaMedicamentos")]
    public virtual Medicamento? IidmedicamentoNavigation { get; set; }
}
