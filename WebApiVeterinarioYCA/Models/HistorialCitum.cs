using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class HistorialCitum
{
    [Key]
    [Column("IIDHISTORIALCITA")]
    public int Iidhistorialcita { get; set; }

    [Column("IIDCITA")]
    public int? Iidcita { get; set; }

    [Column("IIDESTADO")]
    public int? Iidestado { get; set; }

    [Column("IIDUSUARIO")]
    public int? Iidusuario { get; set; }

    [Column("DFECHA", TypeName = "datetime")]
    public DateTime? Dfecha { get; set; }

    [Column("VOBSERVACION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Vobservacion { get; set; }
}
