﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Colecciones.Genericos
{
    public interface IElemento
    {
        int Id { get; set; }
        string? Nombre { get; set; } 
    }
}
