///////////////////////////////////////////////////////////////////////////////////////////////////
//
// Sistema Integral Hospitalario
//
// Copyright (c) 2012, AndJon. Todos los derechos reservados.
// Este archivo es confidencial de AndJon. No distribuir.
//
// Developers : Heber Estrada

using SiHo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiHo.Infraestructure.Persistence.Configurations
{
    /// <summary>
    /// Clase de configuración
    /// </summary>
    class BsanticoagulanteConfiguration : IEntityTypeConfiguration<Bsanticoagulante>
    {
        /// <summary>
        /// Implementa la configuración
        /// </summary>
        /// <param name="entity"> objeto que compila la configuración y la lleva a cabo </param>
        public void Configure(EntityTypeBuilder<Bsanticoagulante> entity)
        {
            entity.HasKey(e => e.Intclave).HasName("bsanticoagulante_pkey");
            entity.Property(e => e.Intclave).ValueGeneratedOnAdd();

            entity.Property(e => e.Intclave)
                .ValueGeneratedOnAdd();

            entity.ToTable("bsanticoagulante");

            entity.HasComment("Este catalogo se usa para dar de alta los diferentes anticoagulantes");

            entity.Property(e => e.Intclave)
                .HasColumnName("intclave")
                .HasColumnType("bigint")
                .HasComment("Clave del anticoagulante (numero consecutivo asignado automaticamente por el sistema)");

            entity.Property(e => e.Bitstatus)
                .HasColumnName("bitstatus")
                .HasColumnType("bigint")
                .HasDefaultValueSql("0")
                .HasComment("Indica si esta  activo/inactivo (guarda 1 = activo, 0 = inactivo)");

            entity.Property(e => e.Vchdescripcion)
                .IsRequired()
                .HasColumnName("vchdescripcion")
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Nombre o descripcion del anticoagulante");
            entity.HasData(
            new Bsanticoagulante

            {
                Intclave = 1,
                Vchdescripcion = "string",
                Bitstatus = true,
                Bitactivo = 1,
            });
        }
    }
}
