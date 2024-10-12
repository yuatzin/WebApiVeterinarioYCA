using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("TipoUsuario")]
public partial class TipoUsuario
{
    [Key]
    [Column("IIDTIPOUSUARIO")]
    public int Iidtipousuario { get; set; }

    [Column("NOMBRE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("DESCRIPCION")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [InverseProperty("IidtipousuarioNavigation")]
    public virtual ICollection<PaginaTipoUsuario> PaginaTipoUsuarios { get; set; } = new List<PaginaTipoUsuario>();

    [InverseProperty("IidtipousuarioNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
