using System;
using Project1.ProcesarEventos.ImprimirEvento;
using Project1;
using Project1.ProcesarEventos.CalculoDiferencia;

namespace Project1.ProcesarEventos.EvaluarEvento
{
    public class EvaluarEvento : IEvaluarEvento
    {
        IGenerarFechaActual GenerarFechaActual = new GenerarFechaActual();
        public EvaluarEvento(IGenerarFechaActual _generarFechaActual)
        {
            this.GenerarFechaActual = _generarFechaActual;
        }
        public bool esEventoMayorHoy(Evento evento)
        {
            if (evento.Fecha > GenerarFechaActual.GenerarFechaActual())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
