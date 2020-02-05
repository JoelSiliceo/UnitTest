using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProcesarEventos.CalculoDiferencia 
{
    public abstract class CalcularDiferencia : ICalcularDiferenciaEventos
    {
        protected Evento evento;
        protected string unidad = string.Empty;
        public CalcularDiferencia(Evento _evento)
        {
            this.evento = _evento;
        }
        
        public virtual int ObtenerDiferencia()
        {
            return 0;
        }

        public  string ObtenerUnidad()
        {
            return this.unidad;
        }
    }
}
