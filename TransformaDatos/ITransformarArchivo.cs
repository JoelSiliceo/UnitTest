using System;
using Project1.LeerDatos;
using System.Collections.Generic;

namespace Project1.TransformaArchivo
{
    public interface ITransformarArchivo
    {
        List<Evento> TransformarArchivoEventos();
    }
}
