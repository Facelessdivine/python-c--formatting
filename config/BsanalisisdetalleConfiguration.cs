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
    class BsanalisisdetalleConfiguration : IEntityTypeConfiguration<Bsanalisisdetalle>
    {
        /// <summary>
        /// Implementa la configuración
        /// </summary>
        /// <param name="entity"> objeto que compila la configuración y la lleva a cabo </param>
        public void Configure(EntityTypeBuilder<Bsanalisisdetalle> entity)
        {
            entity.HasKey(e => e.Intclave).HasName("Bsanalisisdetalle_pkey");
            entity.Property(e => e.Intclave).ValueGeneratedOnAdd();
                    
            entity.ToTable("bsanalisisdetalle");

            entity.HasComment("Esta tabla contiene los resultados de los examenes practicados al donador una vez que fueron revisados por parte del personal del banco de sangre y el donador fue calificado como apto o no apto.");

            entity.Property(e => e.Dtmfecha)
                .HasColumnName("dtmfecha")
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasComment("Fecha en que se guardo el registro.");

            entity.Property(e => e.Intcveanalisis)
                .HasColumnName("intcveanalisis")
                .HasColumnType("bigint")
                .HasComment("Clave del analisis (relacionado con BsAnalisis)");

            entity.Property(e => e.Intcveexamen)
                .HasColumnName("intcveexamen")
                .HasColumnType("bigint")
                .HasComment("Clave del examen realizado al donador (relacionado con LaExamen).");

            entity.Property(e => e.Vchresultado)
                .IsRequired()
                .HasColumnName("vchresultado")
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Resultado del examen.");

            entity.HasOne(d => d.IntcveanalisisNavigation)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasForeignKey(d => d.Intcveanalisis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bsanalisisbsanalisdetalle");
entity.HasData(
new Bsanalisisdetalle

{
 Intclave = 1,
 Intcveanalisis = 1,
 Intcveexamen = 1,
 Dtmfecha = "2018-09-18",
 Vchresultado = "string",
 Bitactivo = 1,
});
}
}
}
