using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProcesarEventos.CalculoDiferencia
{
    public class CalcularDiferenciaXMes : CalcularDiferencia 
    {
        public CalcularDiferenciaXMes(Evento _evento) : base(_evento)
        {
            base.unidad = "meses";
        }

        public override int ObtenerDiferencia()
        {
            int diff = (DateTime.Now - base.evento.Fecha).Days / 30;
            return Math.Abs(diff);
        }


    }
}
