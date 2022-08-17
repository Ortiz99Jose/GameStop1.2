﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists <Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("1234");
            contexto.Usuarios.Add(nuevoUsuario);
            
            base.Seed(contexto);
        }
    }
}
