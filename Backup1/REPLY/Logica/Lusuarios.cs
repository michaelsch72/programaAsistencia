﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace REPLY.Logica
{
    public class Lusuarios
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Icono { get; set; }

        public string Estado { get; set; }
    }
}
