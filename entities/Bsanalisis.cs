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
    public class Bsanalisis
    {
        public long Intcveanalisis { get; set; }
        public long Intcvehistoria { get; set; }
        public DateTime Dtmfecharegistro { get; set; }
        public long Intcompatible { get; set; }
        public int Bitactivo { get; set; }
    }
}
