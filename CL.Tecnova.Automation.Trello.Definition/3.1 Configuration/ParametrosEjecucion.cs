using System.Configuration;

namespace CL.Tecnova.Automation.Trello.Definition
{
    /// <summary>
    /// Clase que contiene los parámetros de ejecución.
    /// </summary>
    public class ParametrosEjecucion
    {
        /// <summary>
        /// Obtiene o asigna Ruta del sitio.
        /// </summary>
        public string RutaDelSitio { get; set; }

        /// <summary>
        /// Obtiene o asigna Navegador.
        /// </summary>
        public string Navegador { get; set; }

        public ParametrosEjecucion()
        {
            RutaDelSitio = "https://trello.com/es";
            Navegador = "Chrome";
        }

    }
}
