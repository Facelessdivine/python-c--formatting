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
    class BsclasificacionpreguntasConfiguration : IEntityTypeConfiguration<Bsclasificacionpreguntas>
    {
        /// <summary>
        /// Implementa la configuración
        /// </summary>
        /// <param name="entity"> objeto que compila la configuración y la lleva a cabo </param>
        public void Configure(EntityTypeBuilder<Bsclasificacionpreguntas> entity)
        {
            entity.HasKey(e => e.Intclave).HasName("bsclasificacionpreguntas_pkey");
            entity.Property(e => e.Intclave).ValueGeneratedOnAdd();
            
            entity.Property(e => e.Intclave)
                .ValueGeneratedOnAdd();

            entity.ToTable("bsclasificacionpreguntas");

            entity.HasComment("Este catalogo se usa para dar de alta las clasificaciones que se usan en el cuestionario que hacen a los donadores");

            entity.Property(e => e.Intclave)
                .HasColumnName("intclave")
                .HasColumnType("bigint")
                .HasComment("Clave de la clasificacion de preguntas (consecutivo)");

            entity.Property(e => e.Bitstatus)
                .HasColumnName("bitstatus")
                .HasColumnType("bigint")
                .HasDefaultValueSql("0")
                .HasComment("Indica si el registro esta  activo/inactivo (guarda 1 = activo, 0 = inactivo)");

            entity.Property(e => e.Vchdescripcion)
                .IsRequired()
                .HasColumnName("vchdescripcion")
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasComment("Descripcion de la clasificacion de preguntas");
entity.HasData(
new Bsclasificacionpreguntas

{
 Intclave = 1,
 Vchdescripcion = "string",
 Bitstatus = true,
 Bitactivo = 1,
});
}
}
}
