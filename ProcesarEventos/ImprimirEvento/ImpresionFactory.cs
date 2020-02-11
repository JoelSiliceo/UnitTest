using Project1.ProcesarEventos.EvaluarEvento;

namespace Project1.ProcesarEventos.ImprimirEvento
{
    public class ImpresionFactory : IImpresionFactory
    {
        private IEvaluarEvento EvaluarEvento { get; set; }
        private Evento Evento { get; set; }

        public ImpresionFactory(IEvaluarEvento _evaluarEvento, Evento _evento)
        {
            this.EvaluarEvento = _evaluarEvento;
            this.Evento = _evento;
        }

        public IImprimirEvento CrearTipoEvento()
        {
            if (this.EvaluarEvento.esEventoMayorHoy(this.Evento))
            {
                return new ImprimirEventoPosterior(this.Evento);
            }
            else
            {
                return new ImprimirEventoAnterior(this.Evento);
            }
        }
    }
}
