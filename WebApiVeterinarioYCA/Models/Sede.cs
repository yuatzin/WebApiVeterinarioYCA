using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("Sede")]
public partial class Sede
{
    [Key]
    [Column("IIDSEDE")]
    public int Iidsede { get; set; }

    [Column("VNOMBRE")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Vnombre { get; set; }

    [Column("VDIRECCION")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Vdireccion { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [InverseProperty("IidsedeNavigation")]
    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();
}
