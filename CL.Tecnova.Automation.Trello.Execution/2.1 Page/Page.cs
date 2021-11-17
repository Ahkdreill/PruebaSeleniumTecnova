using CL.Tecnova.Automation.Trello.Definition;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace CL.Tecnova.Automation.Trello.Execution
{
    public class Page
    {
        #region Miembros

        /// <summary>
        /// Representa a BasePage.
        /// </summary>
        private BasePage _BasePage;

        /// <summary>
        /// Representa las funciones de Wait propias del WebDriver.
        /// </summary>
        private readonly WebDriverWait _Wait;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor predeterminado que inicializa el BasePage.
        /// </summary>
        public Page()
        {
            _BasePage = new BasePage();
            _Wait = new WebDriverWait(PropiedadDriver.GetDriver, TimeSpan.FromSeconds((int)TimeOut.max));
        }

        #endregion

        public void ClickIniciarSesion()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();
            
                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnIniciarSesion));
                elementosWeb.btnIniciarSesion.Click();
            }
            catch (Exception)
            {
                throw new Exception("No es posible hacer click en el botón de inicio de sesión");
            }
        }

        public void IngresarCorreoPassword(string pCorreo, string pPassword)
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.txtCorreo));
                elementosWeb.txtCorreo.SendKeys(pCorreo);

                Thread.Sleep(1000);
                if (_BasePage.IsElementDisplayed(elementosWeb.btnLoginSecundario))
                {
                    elementosWeb.btnLoginSecundario.Click();
                }

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.txtPassword));
                elementosWeb.txtPassword.SendKeys(pPassword);
            }
            catch (Exception)
            {
                throw new Exception("No es posible ingresar datos para el inicio de sesión");
            }
        }

        public void ClickIniciarLoginSesion()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnLogin));
                elementosWeb.btnLogin.Click();

            }
            catch (Exception)
            {
                throw new Exception("No es posible hacer click en el botón de inicio de sesión");
            }
        }

        public bool ValidarMensajeError()
        {
            bool retorno = false;
            ElementosWeb elementosWeb = new ElementosWeb();

            Thread.Sleep(2000);

            if (_BasePage.IsElementDisplayed(elementosWeb.txtMensajeErrorLogin))
            {
                retorno = true;
            }
            
            return retorno;
        }

        public void CrearTablero()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnTablero));
                elementosWeb.btnTablero.Click();

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnCrearTableroNuevo));
                elementosWeb.btnCrearTableroNuevo.Click();

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.txtTituloTablero));
                elementosWeb.txtTituloTablero.SendKeys("Prueba Tablero");

                Thread.Sleep(1000);
                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnCrearTablero));
                elementosWeb.btnCrearTablero.Click();

                Thread.Sleep(2000);

            }
            catch (Exception)
            {
                throw new Exception("No es posible crear el Tablero");
            }
        }

        public void CambiarTituloListas()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                _Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnPrimerTituloLista));
                elementosWeb.btnPrimerTituloLista.Click();

                elementosWeb.txtPrimerTituloLista.SendKeys("Por Hacer");

                elementosWeb.btnFondoTablero.Click();

                //_Wait.Until(_BasePage.IsElementVisible(elementosWeb.btnTercerTituloLista));
                elementosWeb.btnTercerTituloLista.Click();

                elementosWeb.txtTercerTituloLista.SendKeys("Finalizado");

                elementosWeb.btnFondoTablero.Click();

                Thread.Sleep(2000);
            }
            catch (Exception)
            {
                throw new Exception("No es posible cambiar Textos en lista.");
            }
        }

        public void CrearTarjeta()
        {
            string tituloTarjeta = "Tarjeta Prueba";

            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                elementosWeb.btnAgregarTarjeta.Click();

                elementosWeb.txtTituloTarjeta.SendKeys(tituloTarjeta);

                elementosWeb.btnConfirmarAgregarTarjeta.Click();

                Thread.Sleep(2000);
            }
            catch (Exception)
            {
                throw new Exception("No es posible agregar Tarjeta");
            }
        }

        public void EditarTarjeta()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                elementosWeb.btnTarjeta.Click();
                Thread.Sleep(1000);
                elementosWeb.txtTarjetaDescripcion.SendKeys("Descripción Prueba");
                Thread.Sleep(1000);
                elementosWeb.btnEtiquetaDescripcion.Click();
                Thread.Sleep(1000);
                elementosWeb.btnEtiquetaAzul.Click();
                Thread.Sleep(1000);
                elementosWeb.btnCloseEtiqueta.Click();
                Thread.Sleep(1000);

                elementosWeb.btnEtiquetaFecha.Click();
                Thread.Sleep(1000);
                _BasePage.ClearAndSendKeys(elementosWeb.txtEtiquetaFecha, "30/12/2021");
                
                elementosWeb.btnEtiquetaFechaGuardar.Click();
                Thread.Sleep(1000);
                elementosWeb.btnEtiquetaPortada.Click();
                Thread.Sleep(1000);
                elementosWeb.btnPortadaImagen.Click();

            }
            catch (Exception)
            {
                throw new Exception("No es posible editar Tarjeta");
            }
        }

        public void MoverTarjeta()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                elementosWeb.btnTarjeta.Click();
                Thread.Sleep(1000);

                elementosWeb.btnMover.Click();
                Thread.Sleep(1000);

                elementosWeb.cboLista.Click();
                Thread.Sleep(1000);
                //SelectLocation.SelectByValue("En Proceso");
                elementosWeb.optEnProceso.Click();
                Thread.Sleep(1000);
                elementosWeb.btnConfirmarMover.Click();
                Thread.Sleep(3000);
                elementosWeb.btnCerrarEtiqueta.Click();
            }
            catch (Exception)
            {
                throw new Exception("No es posible Mover Tarjeta");
            }
        }

        public void CerrarTarjeta()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();
                
                Thread.Sleep(3000);
                elementosWeb.btnCerrarEtiqueta.Click();
            }
            catch (Exception)
            {
                throw new Exception("No es posible cerrar Tarjeta");
            }
        }

        public void EliminarTablero()
        {
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                Thread.Sleep(1000);
                elementosWeb.btnMostrarMenu.Click();
                Thread.Sleep(1000);
                elementosWeb.btnMas.Click();
                Thread.Sleep(1000);
                elementosWeb.btnCerrarTablero.Click();
                Thread.Sleep(1000);
                elementosWeb.btnConfirmacionCerrarTablero.Click();
                Thread.Sleep(1000);
                elementosWeb.btnEliminarTablero.Click();
                Thread.Sleep(1000);
                elementosWeb.btnConfirmacionEliminarTablero.Click();
                Thread.Sleep(3000);
            }
            catch (Exception)
            {
                throw new Exception("No es posible Eliminar Tablero");
            }
        }

        public bool ValidarRedireccionEspacioTrabajo()
        {
            bool retorno = false;
            
            try
            {
                ElementosWeb elementosWeb = new ElementosWeb();

                Thread.Sleep(2000);

                if (_BasePage.IsElementDisplayed(elementosWeb.lblEspacioDeTrabajo))
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception)
            {
                throw new Exception("No es posible editar Tarjeta");
            }
        }
    }
}
