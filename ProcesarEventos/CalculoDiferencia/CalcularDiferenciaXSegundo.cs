using System;

namespace Project1.ProcesarEventos.CalculoDiferencia
{
    public class CalcularDiferenciaXSegundo : CalcularDiferencia
    {
        public CalcularDiferenciaXSegundo(Evento _evento) : base(_evento)
        {
            base.unidad = "segundos";
        }

        public override int ObtenerDiferencia()
        {
            return Math.Abs((DateTime.Now - evento.Fecha).Seconds);
        }
    }
}
