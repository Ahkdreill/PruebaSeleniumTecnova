using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Tecnova.Automation.Trello.Definition
{
    /// <summary>
    /// Clase que contiene las propiedades relacionadas con el navegador.
    /// </summary>
    public static class AccionNavegador
    {
        /// <summary>
        /// Método que recarga el navegador y accede al sitio de la página.
        /// </summary>
        public static void RecargaNavegadorConSitio()
        {
            try
            {
                ParametrosEjecucion parametrosEjecucion = new ParametrosEjecucion();

                if (PropiedadDriver.GetDriver != null)
                {
                    PropiedadDriver.GetDriver.Manage().Window.Maximize();
                    PropiedadDriver.GetDriver.Navigate().GoToUrl(parametrosEjecucion.RutaDelSitio);
                }
            }
            catch (Exception)
            {
                throw new Exception("El navegador no ha podido ser inicializado");
            }
        }
    }
}
