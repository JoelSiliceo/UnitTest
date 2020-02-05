using Project1.ProcesarEventos.CalculoDiferencia;
using Project1.ProcesarEventos.ImprimirEvento;

namespace Project1.ProcesarEventos.EvaluarEvento
{
    public interface IEvaluarEvento
    {
        bool esEventoMayorHoy(Evento evento);
    }
}
