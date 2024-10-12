using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class TipoMascotum
{
    [Key]
    [Column("IIDTIPOMASCOTA")]
    public int Iidtipomascota { get; set; }

    [Column("NOMBRE")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("DESCRIPCION")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [InverseProperty("IidtipomascotaNavigation")]
    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    [InverseProperty("IidtipomascotaNavigation")]
    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();
}
