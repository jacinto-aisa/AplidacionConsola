﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.PolimorfismoConClases.Services
{
    public interface IFactoriaPersona
    {
        Persona? DamePersona(sbyte edad, string nombreCompleto);
    }
}
