﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDipnicox.Entidades
{
    public class ClPersonalE
    {
        public int idPersonal { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int idTipoPersonal { get; set; }
        public int idCiudad { get; set; }
    }
}