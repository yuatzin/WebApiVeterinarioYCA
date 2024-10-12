using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class Mascotum
{
    [Key]
    [Column("IIDMASCOTA")]
    public int Iidmascota { get; set; }

    [Column("IIDUSUARIOPROPIETARIO")]
    public int? Iidusuariopropietario { get; set; }

    [Column("NOMBRE")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("IIDTIPOMASCOTA")]
    public int? Iidtipomascota { get; set; }

    [Column("FECHANACIMIENTO", TypeName = "datetime")]
    public DateTime Fechanacimiento { get; set; }

    [Column("ANCHO")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ancho { get; set; }

    [Column("ALTURA")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Altura { get; set; }

    [Column("IIDSEXO")]
    public int? Iidsexo { get; set; }

    [Column("VOBSERVACION")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Vobservacion { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Column("VNOMBREARCHIVO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Vnombrearchivo { get; set; }

    [Column("ARCHIVO")]
    public byte[]? Archivo { get; set; }

    [InverseProperty("IidmascotaNavigation")]
    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    [ForeignKey("Iidsexo")]
    [InverseProperty("Mascota")]
    public virtual Sexo? IidsexoNavigation { get; set; }

    [ForeignKey("Iidtipomascota")]
    [InverseProperty("Mascota")]
    public virtual TipoMascotum? IidtipomascotaNavigation { get; set; }

    [ForeignKey("Iidusuariopropietario")]
    [InverseProperty("Mascota")]
    public virtual Usuario? IidusuariopropietarioNavigation { get; set; }

    [InverseProperty("IidmascotaNavigation")]
    public virtual ICollection<UsuarioMascotum> UsuarioMascota { get; set; } = new List<UsuarioMascotum>();
}
