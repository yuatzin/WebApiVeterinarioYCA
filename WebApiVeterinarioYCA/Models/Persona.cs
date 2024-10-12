using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("Persona")]
public partial class Persona
{
    [Key]
    [Column("IIDPERSONA")]
    public int Iidpersona { get; set; }

    [Column("NOMBRE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("APPATERNO")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Appaterno { get; set; }

    [Column("APMATERNO")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Apmaterno { get; set; }

    [Column("TELEFONO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [Column("CORREO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Correo { get; set; }

    [Column("FECHANACIMIENTO", TypeName = "datetime")]
    public DateTime? Fechanacimiento { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Column("BTIENEUSUARIO")]
    public int? Btieneusuario { get; set; }

    [Column("IIDSEXO")]
    public int? Iidsexo { get; set; }

    [Column("VNOMBREARCHIVO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Vnombrearchivo { get; set; }

    [Column("VARCHIVO")]
    public byte[]? Varchivo { get; set; }

    [ForeignKey("Iidsexo")]
    [InverseProperty("Personas")]
    public virtual Sexo? IidsexoNavigation { get; set; }

    [InverseProperty("IidpersonaNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
