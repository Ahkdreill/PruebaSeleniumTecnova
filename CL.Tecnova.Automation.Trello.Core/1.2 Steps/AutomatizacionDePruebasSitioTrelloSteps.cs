using CL.Tecnova.Automation.Trello.Execution;
using NUnit.Framework;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace CL.Tecnova.Automation.Trello.Core
{
    [Scope(Feature = "Automatización de pruebas sitio Trello.com")]
    [Binding]
    public class AutomatizacionDePruebasSitioTrelloSteps
    {
        #region Miembros
            
        private readonly Page _Page;

        #endregion

        #region Constructor

        public AutomatizacionDePruebasSitioTrelloSteps()
        {
            _Page = new Page();
        }

        #endregion

        #region CP01

        [Given(@"El usuario presiona el botón de inicio de sesión")]
        public void GivenElUsuarioPresionaElBotonDeInicioDeSesion()
        {
            _Page.ClickIniciarSesion();
        }

        [Given(@"El usuario ingresa correo (.*) y contraseña (.*) incorrectos")]
        public void GivenElUsuarioIngresaCorreoYContrasenaIncorrectos(string pCorreo, string pPassword)
        {
            _Page.IngresarCorreoPassword(pCorreo, pPassword);
        }


        [When(@"El usuario presiona el botón ingresar")]
        public void WhenElUsuarioPresionaElBotonIngresar()
        {
            _Page.ClickIniciarLoginSesion();
        }

        [Then(@"El sistema no permite ingresar al sitio")]
        public void ThenElSistemaNoPermiteIngresarAlSitio()
        {
            Assert.IsTrue(_Page.ValidarMensajeError(), "No es mostrado mensaje de error.");
        }

        #endregion

        #region CP02

        [Given(@"El usuario ingresa a la aplicación utilizando correo (.*) y contraseña (.*)")]
        public void GivenElUsuarioIngresaALaAplicacionUtilizandoCorreoYContrasena(string pCorreo, string pPassword)
        {
            _Page.ClickIniciarSesion();
            _Page.IngresarCorreoPassword(pCorreo, pPassword);
            _Page.ClickIniciarLoginSesion();
        }

        [Given(@"El usuario crea crea un Tablero")]
        public void GivenElUsuarioCreaCreaUnTablero()
        {
            _Page.CrearTablero();
        }

        [Given(@"El usuario crea las listas Por Hacer - En Proceso - Finalizado")]
        public void GivenElUsuarioCreaLasListasPorHacer_EnProceso_Finalizado()
        {
            _Page.CambiarTituloListas();
        }

        [When(@"El usuario crea una tarjeta en la Lista Por Hacer")]
        public void WhenElUsuarioCreaUnaTarjetaEnLaListaPorHacer()
        {
            _Page.CrearTarjeta();
        }

        [When(@"Ingresa Descripción - Etiqueta color Azul - Fecha de vencimiento - Archivo adjunto - Portada - Comentario\.")]
        public void WhenIngresaDescripcion_EtiquetaColorAzul_FechaDeVencimiento_ArchivoAdjunto_Portada_Comentario_()
        {
            _Page.EditarTarjeta();
        }

        [When(@"El usuario guarda los cambios\.")]
        public void WhenElUsuarioGuardaLosCambios_()
        {
            //_Page.MoverTarjeta();
        }

        [When(@"El usuario cierra la tarjeta usando el botón X")]
        public void WhenElUsuarioCierraLaTarjetaUsandoElBotonX()
        {
            _Page.CerrarTarjeta();
        }

        [Then(@"El usuario Mueve la tarjeta a En Proceso")]
        public void ThenElUsuarioMueveLaTarjetaAEnProceso()
        {
            _Page.MoverTarjeta();
        }

        [Then(@"El usuario Elimina el Tablero")]
        public void ThenElUsuarioEliminaElTablero()
        {
            _Page.EliminarTablero();
            Assert.IsTrue(_Page.ValidarRedireccionEspacioTrabajo(), "No es logró eliminar el tablero.");
        }

        #endregion

    }
}
