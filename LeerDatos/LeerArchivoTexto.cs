using System;

namespace Project1.LeerDatos
{
    public class LeerArchivoTexto : ILeerArchivo
    {
        private string Ruta { get; set; }
        public LeerArchivoTexto(string ruta)
        {
            this.Ruta = ruta;
        }

        string[] ILeerArchivo.LeerArchivoTexto()
        {
            string[] lineas = null;
            try
            {
                lineas = System.IO.File.ReadAllLines(this.Ruta);
            }
            catch
            {
                throw new Exception("Error al cargar el archivo");
            }

            return lineas;
        }
    }
}
