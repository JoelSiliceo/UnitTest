using Project1.ProcesarEventos.CalculoDiferencia;
using Project1.ProcesarEventos.EvaluarEvento;
using System.Collections.Generic;


namespace Project1.ProcesarEventos.ImprimirEvento
{
    public abstract class ImprimirEvento : IImprimirEvento
    {
        private Evento evento;

        public static ImprimirEvento CrearTipoEvento(IEvaluarEvento _EvaluarEvento, Evento _evento)
        {
            if (_EvaluarEvento.esEventoMayorHoy(_evento))
            {
                return new ImprimirEventoPosterior(_evento);
            }
            else
            {
                return new ImprimirEventoAnterior(_evento);
            }
        }

        protected ImprimirEvento(Evento _evento)
        {
            this.evento = _evento;
        }
        

        public virtual void ImprimirEnConsola(List<ICalcularDiferenciaEventos> calculadores)
        {
           
        }   

        private string FormatearCadena(string[] textos)
        {

            string cadenaFormateada = string.Format("{0} {1} en {2} {3}.", textos[0], textos[1], textos[2], textos[3]);
            return cadenaFormateada;
        }

        private string[] ObtenerTextos(string unidad, string diferenciaTiempo , string texto)
        {
            string[] textos = new string[4];

            textos[0] = this.evento.Descripcion;
            textos[1] = texto;
            textos[2] = diferenciaTiempo;
            textos[3] = unidad;

            return textos;
        }

        private bool tieneValorImpresion(string[] textos, int diferenciaTiempo)
        {
            if (diferenciaTiempo == 0)
            {
                return false;
            }

            return true;
        }
               

        private void ImprimirSalida(string salida)
        {
            System.Console.WriteLine(salida);
        }

        protected void ImprimirLista(List<ICalcularDiferenciaEventos> calculadores, string textoConjugado)
        {
            foreach (ICalcularDiferenciaEventos calculador in calculadores)
            {
                int diferenciaTiempo = calculador.ObtenerDiferencia();
                string unidad = calculador.ObtenerUnidad();
                string[] textos = ObtenerTextos(unidad, diferenciaTiempo.ToString(), textoConjugado);

                if (tieneValorImpresion(textos, diferenciaTiempo))
                {
                    string salida = FormatearCadena(textos);
                    ImprimirSalida(salida);
                    break;
                }
            }
        }
    }
}
