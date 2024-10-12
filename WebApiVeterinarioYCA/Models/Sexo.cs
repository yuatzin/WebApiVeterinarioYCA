using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("Sexo")]
public partial class Sexo
{
    [Key]
    [Column("IIDSEXO")]
    public int Iidsexo { get; set; }

    [Column("NOMBRE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [InverseProperty("IidsexoNavigation")]
    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();

    [InverseProperty("IidsexoNavigation")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
