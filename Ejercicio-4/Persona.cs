﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public abstract class Persona
    {
        //prop 
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public int Edad { get; set; }
        public char Genero { get; set; }
    }
}
