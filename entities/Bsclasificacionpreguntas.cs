///////////////////////////////////////////////////////////////////////////////////////////////////
//
// Sistema Integral Hospitalario
//
// Copyright (c) 2012, AndJon. Todos los derechos reservados.
// Este archivo es confidencial de AndJon. No distribuir.
//
// Developers : Heber Estrada

using System;
using System.Collections.Generic;

namespace SiHo.Domain.Entities
{
    public class Bsclasificacionpreguntas
    {
        public Bsclasificacionpreguntas()
        {
            Bspregunta = new HashSet<Bspregunta>();
        }

        public long Intclave { get; set; }
        public string Vchdescripcion { get; set; }
        public bool? Bitstatus { get; set; }
        public int Bitactivo { get; set; }

        public ICollection<Bspregunta> Bspregunta { get; set; }
    }
}
