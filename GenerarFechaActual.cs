using System;


namespace Project1
{
    public class GenerarFechaActual : IGenerarFechaActual
    {
        DateTime IGenerarFechaActual.GenerarFechaActual()
        {
            return DateTime.Now;
        }
    }
}
