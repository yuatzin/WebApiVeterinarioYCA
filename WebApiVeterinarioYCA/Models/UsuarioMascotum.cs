using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class UsuarioMascotum
{
    [Key]
    [Column("IIDPERSONAMASCOTA")]
    public int Iidpersonamascota { get; set; }

    [Column("IIDUSUARIO")]
    public int? Iidusuario { get; set; }

    [Column("IIDMASCOTA")]
    public int? Iidmascota { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [ForeignKey("Iidmascota")]
    [InverseProperty("UsuarioMascota")]
    public virtual Mascotum? IidmascotaNavigation { get; set; }

    [ForeignKey("Iidusuario")]
    [InverseProperty("UsuarioMascota")]
    public virtual Usuario? IidusuarioNavigation { get; set; }
}
