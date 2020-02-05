using Project1.ProcesarEventos.CalculoDiferencia;
using Project1.ProcesarEventos.EvaluarEvento;
using System.Collections.Generic;

namespace Project1.ProcesarEventos.ImprimirEvento
{
    public class ImprimirEventoAnterior: ImprimirEvento
    {
        public ImprimirEventoAnterior(Evento _evento) : base(_evento)
        {

        }

        public override void ImprimirEnConsola(List<ICalcularDiferenciaEventos> calculadores)
        {
            string verboTexto = AsignarVerboTexto();
            base.ImprimirLista(calculadores, verboTexto);
        }

        private string AsignarVerboTexto ()
        {
            return "ocurrió";
        }
    }
}
