using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("Usuario")]
public partial class Usuario
{
    [Key]
    [Column("IIDUSUARIO")]
    public int Iidusuario { get; set; }

    [Column("NOMBREUSUARIO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nombreusuario { get; set; }

    [Column("CONTRA")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Contra { get; set; }

    [Column("IIDPERSONA")]
    public int? Iidpersona { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Column("IIDTIPOUSUARIO")]
    public int? Iidtipousuario { get; set; }

    [InverseProperty("IiddoctorasignacitausuarioNavigation")]
    public virtual ICollection<Citum> CitumIiddoctorasignacitausuarioNavigations { get; set; } = new List<Citum>();

    [InverseProperty("IidusuarioNavigation")]
    public virtual ICollection<Citum> CitumIidusuarioNavigations { get; set; } = new List<Citum>();

    [ForeignKey("Iidpersona")]
    [InverseProperty("Usuarios")]
    public virtual Persona? IidpersonaNavigation { get; set; }

    [ForeignKey("Iidtipousuario")]
    [InverseProperty("Usuarios")]
    public virtual TipoUsuario? IidtipousuarioNavigation { get; set; }

    [InverseProperty("IidusuariopropietarioNavigation")]
    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();

    [InverseProperty("IidusuarioNavigation")]
    public virtual ICollection<UsuarioMascotum> UsuarioMascota { get; set; } = new List<UsuarioMascotum>();
}
