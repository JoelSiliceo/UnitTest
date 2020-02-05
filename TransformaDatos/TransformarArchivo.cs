using System;
using System.Collections.Generic;
using Project1.LeerDatos;

namespace Project1.TransformaArchivo
{
    public class TransformarEventosXComa : ITransformarArchivo
    {
        private const char separador = ',';
        private ILeerArchivo lectorDatos;

        public TransformarEventosXComa(ILeerArchivo _lectorDatos)
        {
            this.lectorDatos = _lectorDatos;
        }

        public List<Evento> TransformarArchivoEventos()
        {
            List<Evento> lsEventos = new List<Evento>();
            string[] lineas = this.lectorDatos.LeerArchivoTexto();
            try
            {
                foreach (string linea in lineas)
                {
                    Evento evt = AsignarEvento(linea);
                    lsEventos.Add(evt);
                }
            }
            catch
            {
                throw new Exception("Error al cargar los datos");
            }

            return lsEventos;
        }

        private Evento AsignarEvento(string linea)
        {
            Evento evt = new Evento();

            try
            {
                evt.Descripcion = linea.Split(separador)[0];
                evt.Fecha = Convert.ToDateTime(linea.Split(separador)[1]);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error al dividir la cadena: {0}" , ex.Message));
            }
            
            return evt;
        }
    }
}
