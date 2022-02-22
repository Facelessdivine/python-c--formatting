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
    class BsanalisisConfiguration : IEntityTypeConfiguration<Bsanalisis>
    {
        /// <summary>
        /// Implementa la configuración
        /// </summary>
        /// <param name="entity"> objeto que compila la configuración y la lleva a cabo </param>
        public void Configure(EntityTypeBuilder<Bsanalisis> entity)
        {
            entity.HasKey(e => e.Intcveanalisis).HasName("bsanalisis_pkey");

            entity.Property(e => e.Intcveanalisis)
                .ValueGeneratedOnAdd();

            entity.ToTable("bsanalisis");

            entity.HasComment("Esta tabla contiene los analisis practicados a cada donador.");

            entity.Property(e => e.Intcveanalisis)
                .HasColumnName("intcveanalisis")
                .HasColumnType("bigint")
                .HasComment("Clave del analisis (consecutivo).");

            entity.Property(e => e.Dtmfecharegistro)
                .HasColumnName("dtmfecharegistro")
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasComment("Fecha en que se efectuo el analisis.");

            entity.Property(e => e.Intcompatible)
                .HasColumnName("intcompatible")
                .HasColumnType("bigint")
                .HasComment("NO SE UTILIZA");

            entity.Property(e => e.Intcvehistoria)
                .HasColumnName("intcvehistoria")
                .HasColumnType("bigint")
                .HasComment("Clave de la historia del donador al que se le hizo el analisis (relacionado con BsHistoria).");
            entity.HasData(
            new Bsanalisis

            {
                Intcveanalisis = 1,
                Intcvehistoria = 1,
                Dtmfecharegistro = "2018-09-18",
                Intcompatible = 1,
                Bitactivo = 1,
            });
        }
    }
}
