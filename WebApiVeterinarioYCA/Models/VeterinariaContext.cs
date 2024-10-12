using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiVeterinarioYCA.Models;

public partial class VeterinariaContext : DbContext
{
    public VeterinariaContext()
    {
    }

    public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CitaMedicamento> CitaMedicamentos { get; set; }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<EstadoCitum> EstadoCita { get; set; }

    public virtual DbSet<HistorialCitum> HistorialCita { get; set; }

    public virtual DbSet<Mascotum> Mascota { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Pagina> Paginas { get; set; }

    public virtual DbSet<PaginaTipoUsuario> PaginaTipoUsuarios { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Sede> Sedes { get; set; }

    public virtual DbSet<Sexo> Sexos { get; set; }

    public virtual DbSet<TipoMascotum> TipoMascota { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioMascotum> UsuarioMascota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SQL8020.site4now.net;Database=db_aad3cf_bdveterinaria;User Id=db_aad3cf_bdveterinaria_admin;Password=Molo..**1122;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<CitaMedicamento>(entity =>
        {
            entity.HasOne(d => d.IidcitaNavigation).WithMany(p => p.CitaMedicamentos).HasConstraintName("FK__CitaMedic__IIDCI__6A30C649");

            entity.HasOne(d => d.IidmedicamentoNavigation).WithMany(p => p.CitaMedicamentos).HasConstraintName("FK__CitaMedic__IIDME__6B24EA82");
        });

        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasOne(d => d.IiddoctorasignacitausuarioNavigation).WithMany(p => p.CitumIiddoctorasignacitausuarioNavigations).HasConstraintName("FK__Cita__IIDDOCTORA__6477ECF3");

            entity.HasOne(d => d.IidestadocitaNavigation).WithMany(p => p.Cita).HasConstraintName("FK__Cita__IIDESTADOC__656C112C");

            entity.HasOne(d => d.IidmascotaNavigation).WithMany(p => p.Cita).HasConstraintName("FK__Cita__IIDMASCOTA__66603565");

            entity.HasOne(d => d.IidsedeNavigation).WithMany(p => p.Cita).HasConstraintName("FK__Cita__IIDSEDE__6754599E");

            entity.HasOne(d => d.IidtipomascotaNavigation).WithMany(p => p.Cita).HasConstraintName("FK__Cita__IIDTIPOMAS__68487DD7");

            entity.HasOne(d => d.IidusuarioNavigation).WithMany(p => p.CitumIidusuarioNavigations).HasConstraintName("FK__Cita__IIDUSUARIO__693CA210");
        });

        modelBuilder.Entity<Mascotum>(entity =>
        {
            entity.HasOne(d => d.IidsexoNavigation).WithMany(p => p.Mascota).HasConstraintName("FK_Mascota_Sexo");

            entity.HasOne(d => d.IidtipomascotaNavigation).WithMany(p => p.Mascota).HasConstraintName("FK__Mascota__IIDTIPO__6C190EBB");

            entity.HasOne(d => d.IidusuariopropietarioNavigation).WithMany(p => p.Mascota).HasConstraintName("FK__Mascota__IIDUSUA__6D0D32F4");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.Iidmedicamento).HasName("PK__Medicame__992AF5C5B08C8695");
        });

        modelBuilder.Entity<Pagina>(entity =>
        {
            entity.HasKey(e => e.Iidpagina).HasName("PK_Paginas");
        });

        modelBuilder.Entity<PaginaTipoUsuario>(entity =>
        {
            entity.HasOne(d => d.IidpaginaNavigation).WithMany(p => p.PaginaTipoUsuarios).HasConstraintName("FK__PaginaTip__IIDPA__6EF57B66");

            entity.HasOne(d => d.IidtipousuarioNavigation).WithMany(p => p.PaginaTipoUsuarios).HasConstraintName("FK__PaginaTip__IIDTI__6FE99F9F");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasOne(d => d.IidsexoNavigation).WithMany(p => p.Personas).HasConstraintName("FK__Persona__IIDSEXO__70DDC3D8");
        });

        modelBuilder.Entity<TipoMascotum>(entity =>
        {
            entity.HasKey(e => e.Iidtipomascota).HasName("PK_TipoMascotas");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasOne(d => d.IidpersonaNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK_Usuario_Persona");

            entity.HasOne(d => d.IidtipousuarioNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK__Usuario__IIDTIPO__71D1E811");
        });

        modelBuilder.Entity<UsuarioMascotum>(entity =>
        {
            entity.HasKey(e => e.Iidpersonamascota).HasName("PK_PERSONAMASCOTA");

            entity.HasOne(d => d.IidmascotaNavigation).WithMany(p => p.UsuarioMascota).HasConstraintName("FK__UsuarioMa__IIDMA__73BA3083");

            entity.HasOne(d => d.IidusuarioNavigation).WithMany(p => p.UsuarioMascota).HasConstraintName("FK__UsuarioMa__IIDUS__74AE54BC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
