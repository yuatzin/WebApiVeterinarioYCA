using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

[Table("Pagina")]
public partial class Pagina
{
    [Key]
    [Column("IIDPAGINA")]
    public int Iidpagina { get; set; }

    [Column("MENSAJE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Mensaje { get; set; }

    [Column("ACCION")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Accion { get; set; }

    [Column("BHABILITADO")]
    public int? Bhabilitado { get; set; }

    [Column("CONTROLADOR")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Controlador { get; set; }

    [InverseProperty("IidpaginaNavigation")]
    public virtual ICollection<PaginaTipoUsuario> PaginaTipoUsuarios { get; set; } = new List<PaginaTipoUsuario>();
}
