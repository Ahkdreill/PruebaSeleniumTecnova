using System;
using System.Diagnostics;

namespace CL.Tecnova.Automation.Trello.Definition
{
    /// <summary>
    /// Clase que contiene contiene el killer de procesos
    /// </summary>
    public static class ProcessKiller
    {
        /// <summary>
        /// Método que realiza Kill a los procesos relacionados con chrome.
        /// </summary>
        public static void ProcessMurderer()
        {
            try
            {
                ChromeDriverMurderer();
                ChromeBrowserMurderer();

                PropiedadDriver.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método que realiza Kill al proceso de chromedriver.exe
        /// </summary>
        private static void ChromeDriverMurderer()
        {
            try
            {
                Process[] procesos = Process.GetProcessesByName("chromedriver", Environment.MachineName);

                foreach (var proceso in procesos)
                {
                    proceso.Kill();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método que realiza Kill al proceso de Google Chrome
        /// </summary>
        private static void ChromeBrowserMurderer()
        {
            try
            {
                Process[] procesosNavegador = Process.GetProcessesByName("chrome", Environment.MachineName);

                foreach (var item in procesosNavegador)
                {
                    item.Kill();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
