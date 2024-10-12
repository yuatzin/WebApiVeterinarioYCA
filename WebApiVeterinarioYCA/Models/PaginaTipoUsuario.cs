using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("PaginaTipoUsuario")]
public partial class PaginaTipoUsuario
{
    [Key]
    [Column("IIDPAGINATIPOUSUARIO")]
    public int Iidpaginatipousuario { get; set; }

    [Column("IIDPAGINA")]
    public int? Iidpagina { get; set; }

    [Column("IIDTIPOUSUARIO")]
    public int? Iidtipousuario { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Column("IIDVISTA")]
    public int? Iidvista { get; set; }

    [ForeignKey("Iidpagina")]
    [InverseProperty("PaginaTipoUsuarios")]
    public virtual Pagina? IidpaginaNavigation { get; set; }

    [ForeignKey("Iidtipousuario")]
    [InverseProperty("PaginaTipoUsuarios")]
    public virtual TipoUsuario? IidtipousuarioNavigation { get; set; }
}
