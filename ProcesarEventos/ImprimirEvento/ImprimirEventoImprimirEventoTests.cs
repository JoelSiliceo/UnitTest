using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project1.ProcesarEventos.EvaluarEvento;
using Project1.LeerDatos;
using Project1.TransformaArchivo;
using System;
using System.Collections.Generic;

namespace Project1.ProcesarEventos.ImprimirEvento.Tests
{
    [TestClass()]
    public class ImprimirEventoImprimirEventoTests
    {
        [TestMethod()]
        public void RevisarFecha_esEventoMayorHoy_true()
        {
            //ARRANGE
            var DOCIGenerarFechaActual = new Mock<IGenerarFechaActual>();
            DateTime simulaHoy = Convert.ToDateTime("01/01/2020");
            DOCIGenerarFechaActual.Setup(f => f.GenerarFechaActual()).Returns(simulaHoy);
            var DOCEvento = new Evento();
            DOCEvento.Descripcion = "Evento1";
            DOCEvento.Fecha = Convert.ToDateTime("25/03/2020");
            var EvalEvento = new EvaluarEvento.EvaluarEvento(DOCIGenerarFechaActual.Object);

            //ACT
            var SUT = EvalEvento.esEventoMayorHoy(DOCEvento);



            //ASSERT
            Assert.AreEqual(true, SUT);
        }


        [TestMethod()]
        public void CrearTipoEvento_esUnEventoMayorAFecha_ImprimirEventoPosterior()
        {
            //ARRANGE
            var DOCIEvaluarEvento = new Mock<IEvaluarEvento>();
            var IImprimirEvento = 
            DOCIEvaluarEvento.Setup(e => e.esEventoMayorHoy(It.IsAny<Evento>())).Returns(true);
            var imprimirFactory = new ImpresionFactory(DOCIEvaluarEvento.Object, new Evento());

            //ACT
            var SUT = imprimirFactory.CrearTipoEvento();
           
            //ASSERT
            Assert.AreEqual(typeof(ImprimirEventoPosterior), SUT.GetType());
        }


        [TestMethod()]//SPIE
        public void ProcesarArchivo_InvocaDependencia_UnaVez()
        {
            //ARRANGE
            var DOCILeerArchivoService = new Mock<ILeerArchivo>();
            string[] arrCadena = new string[] { "evento1,25/01/2020" };
            DOCILeerArchivoService.Setup(doc => doc.LeerArchivoTexto()).Returns(arrCadena);
            var SUT = new TransformarEventosXComa(DOCILeerArchivoService.Object);


            //ACT
            List<Evento> lstEventos = SUT.TransformarArchivoEventos();
            

            //ASSERT
            DOCILeerArchivoService.Verify(a => a.LeerArchivoTexto(), Times.Once);
        }
    }
}