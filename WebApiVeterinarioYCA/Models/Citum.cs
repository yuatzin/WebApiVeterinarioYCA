using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class Citum
{
    [Key]
    [Column("IIDCITA")]
    public int Iidcita { get; set; }

    [Column("IIDUSUARIO")]
    public int? Iidusuario { get; set; }

    [Column("IIDTIPOMASCOTA")]
    public int? Iidtipomascota { get; set; }

    [Column("IIDMASCOTA")]
    public int? Iidmascota { get; set; }

    [Column("VDESCRIPCION")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Vdescripcion { get; set; }

    [Column("VMEDIDASTOMADAS")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Vmedidastomadas { get; set; }

    [Column("DFECHAENFERMO", TypeName = "datetime")]
    public DateTime? Dfechaenfermo { get; set; }

    [Column("DFECHAINICIO", TypeName = "datetime")]
    public DateTime? Dfechainicio { get; set; }

    [Column("PRECIOATENCION", TypeName = "decimal(18, 2)")]
    public decimal? Precioatencion { get; set; }

    [Column("TOTALPAGAR", TypeName = "decimal(18, 2)")]
    public decimal? Totalpagar { get; set; }

    [Column("IIDSEDE")]
    public int? Iidsede { get; set; }

    [Column("IIDDOCTORASIGNACITAUSUARIO")]
    public int? Iiddoctorasignacitausuario { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Column("IIDESTADOCITA")]
    public int? Iidestadocita { get; set; }

    [Column("DFECHACITA", TypeName = "datetime")]
    public DateTime? Dfechacita { get; set; }

    [InverseProperty("IidcitaNavigation")]
    public virtual ICollection<CitaMedicamento> CitaMedicamentos { get; set; } = new List<CitaMedicamento>();

    [ForeignKey("Iiddoctorasignacitausuario")]
    [InverseProperty("CitumIiddoctorasignacitausuarioNavigations")]
    public virtual Usuario? IiddoctorasignacitausuarioNavigation { get; set; }

    [ForeignKey("Iidestadocita")]
    [InverseProperty("Cita")]
    public virtual EstadoCitum? IidestadocitaNavigation { get; set; }

    [ForeignKey("Iidmascota")]
    [InverseProperty("Cita")]
    public virtual Mascotum? IidmascotaNavigation { get; set; }

    [ForeignKey("Iidsede")]
    [InverseProperty("Cita")]
    public virtual Sede? IidsedeNavigation { get; set; }

    [ForeignKey("Iidtipomascota")]
    [InverseProperty("Cita")]
    public virtual TipoMascotum? IidtipomascotaNavigation { get; set; }

    [ForeignKey("Iidusuario")]
    [InverseProperty("CitumIidusuarioNavigations")]
    public virtual Usuario? IidusuarioNavigation { get; set; }
}
