using System;

namespace Project1.ProcesarEventos.CalculoDiferencia
{
    public class CalcularDiferenciaXHora : CalcularDiferencia
    {
        public CalcularDiferenciaXHora(Evento _evento) : base(_evento)
        {
            base.unidad = "horas";
        }

        public override int ObtenerDiferencia()
        {
            return Math.Abs((DateTime.Now - evento.Fecha).Hours);
        }


    }
}
