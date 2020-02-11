using Project1.ProcesarEventos.CalculoDiferencia;
using Project1.ProcesarEventos.EvaluarEvento;
using Project1.ProcesarEventos.ImprimirEvento;
using Project1.TransformaArchivo;
using System.Collections.Generic;

namespace Project1.ProcesarEventos 
{
    public class ProcesarEventos : IProcesarEventos
    {
        private ITransformarArchivo transformadorEventos;

        public ProcesarEventos(ITransformarArchivo _transformadorEventos)
        {
            this.transformadorEventos = _transformadorEventos;
        }

        void IProcesarEventos.ProcesarEventos()
        {
            List<Evento> eventos = transformadorEventos.TransformarArchivoEventos();
            IGenerarFechaActual generarFechaActual = new GenerarFechaActual();
            IEvaluarEvento evalEvento = new EvaluarEvento.EvaluarEvento(generarFechaActual);
            IImpresionFactory impresionFactory;
            IImprimirEvento imprimirEventos;

            foreach (Evento evento in eventos)
            {
                List<ICalcularDiferenciaEventos> calculadores = this.GenerarListaCaculadores(evento);
                impresionFactory = new ImpresionFactory(evalEvento, evento);
                imprimirEventos = impresionFactory.CrearTipoEvento();
                imprimirEventos.ImprimirEnConsola(calculadores);
            }
        }

        private List<ICalcularDiferenciaEventos> GenerarListaCaculadores(Evento evento)
        {
            List<ICalcularDiferenciaEventos> calculadores = new List<ICalcularDiferenciaEventos>();
            ICalcularDiferenciaEventos calcDifMes = new CalcularDiferenciaXMes(evento);
            ICalcularDiferenciaEventos calcDifDia = new CalcularDiferenciaXDia(evento);
            ICalcularDiferenciaEventos calcDifHora = new CalcularDiferenciaXHora(evento);
            ICalcularDiferenciaEventos calcDifMinuto = new CalcularDiferenciaXMinutos(evento);

            calculadores.Add(calcDifMes);
            calculadores.Add(calcDifDia);
            calculadores.Add(calcDifHora);
            calculadores.Add(calcDifMinuto);

            return calculadores;
        }
    }
}
