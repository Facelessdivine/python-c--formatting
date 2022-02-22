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
    public class Bsanalisisdetalle
    {
        public long Intclave { get; set; }
        public long Intcveanalisis { get; set; }
        public long Intcveexamen { get; set; }
        public DateTime Dtmfecha { get; set; }
        public string Vchresultado { get; set; }
        public int Bitactivo { get; set; }

        public Bsanalisis IntcveanalisisNavigation { get; set; }
    }
}
