using System;

namespace Project1.ProcesarEventos.CalculoDiferencia
{
    public class CalcularDiferenciaXMinutos  : CalcularDiferencia
    {
        public CalcularDiferenciaXMinutos(Evento _evento) : base(_evento)
        {
            base.unidad = "minutos";
        }

        public override int ObtenerDiferencia()
        {
            return Math.Abs((DateTime.Now - evento.Fecha).Minutes);
        }
    }
}
