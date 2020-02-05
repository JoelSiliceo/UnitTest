using Project1.ProcesarEventos.CalculoDiferencia;
using Project1.ProcesarEventos.EvaluarEvento;
using System.Collections.Generic;

namespace Project1.ProcesarEventos.ImprimirEvento
{
    public interface IImprimirEvento
    {
        void ImprimirEnConsola(List<ICalcularDiferenciaEventos> calculadores);
    }
}
