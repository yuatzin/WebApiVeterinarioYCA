using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class EstadoCitum
{
    [Key]
    [Column("IIDESTADO")]
    public int Iidestado { get; set; }

    [Column("VNOMBRE")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Vnombre { get; set; }

    [Column("VDESCRIPCION")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Vdescripcion { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [InverseProperty("IidestadocitaNavigation")]
    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();
}
