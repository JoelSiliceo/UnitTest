using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProcesarEventos.CalculoDiferencia
{
    public class CalcularDiferenciaXDia : CalcularDiferencia
    {
        public CalcularDiferenciaXDia(Evento _evento) : base(_evento)
        {
            base.unidad = "días";
        }
        public override int ObtenerDiferencia()
        {
            return Math.Abs((DateTime.Now - evento.Fecha).Days);
        }

    }
}
