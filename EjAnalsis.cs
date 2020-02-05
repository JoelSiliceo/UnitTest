using Project1.LeerDatos;
using System;
using System.Collections.Generic;
using Project1.TransformaArchivo;
using System.Linq;
using Project1.ProcesarEventos;

namespace Project1
{
    public class EjAnalsis
    {
        public static void Main(string[] args)
        {
            try
            {
                ILeerArchivo lectorArchivoTxt = new LeerArchivoTexto(args[0]);
                ITransformarArchivo transformarEventos = new TransformarEventosXComa(lectorArchivoTxt);
                IProcesarEventos procesarEventos = new ProcesarEventos.ProcesarEventos(transformarEventos);
                procesarEventos.ProcesarEventos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
