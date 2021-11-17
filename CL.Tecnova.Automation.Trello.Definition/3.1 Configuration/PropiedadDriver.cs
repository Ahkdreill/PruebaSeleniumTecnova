using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace CL.Tecnova.Automation.Trello.Definition
{
    public static class PropiedadDriver
    {
        //Establecer objeto web driver
        private static IWebDriver _driver;

        #region Métodos de la clase

        /// <summary>
        /// Cargar web driver
        /// </summary>
        public static void LoadDriver()
        {
            try
            {
                ParametrosEjecucion parametrosEjecucion = new ParametrosEjecucion();

                switch (parametrosEjecucion.Navegador)
                {
                    case "Chrome":
                        _driver = new ChromeDriver();
                        break;

                    case "Firefox":
                        _driver = new FirefoxDriver();
                        break;

                    case "Explore":
                        _driver = new InternetExplorerDriver();
                        break;

                    default:
                        throw new ExcepcionPrueba(parametrosEjecucion.Navegador + "no es compatible");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("El navegador no se ha cargado");
            }
        }

        /// <summary>
        /// Obtener web driver
        /// </summary>
        /// <value>Get driver</value>
        public static IWebDriver GetDriver
        {
            get
            {
                try
                {
                    if (_driver != null)
                    {
                        return _driver;
                    }

                    LoadDriver();

                    return _driver;
                }
                catch (ExcepcionPrueba)
                {
                    throw new ExcepcionPrueba("Driver no ha sido cargado");
                }
            }
        }

        /// <summary>
        /// Obtener tiempo de espera para driver
        /// </summary>
        /// <returns>Espera del driver</returns>
        /// <param name="timeout">Timeout.</param>
        public static WebDriverWait GetDriverWait(int timeout)
        {
            WebDriverWait waitDriver;

            try
            {
                waitDriver = new WebDriverWait(GetDriver, TimeSpan.FromSeconds(timeout));
            }
            catch (Exception)
            {
                throw new Exception("Error grave al cargar driver");
            }

            return waitDriver;
        }

        /// <summary>
        /// Asignar valor null a WebDriver
        /// </summary>
        public static void Dispose()
        {
            if (_driver != null)
            {
                _driver = null;
            }
        }

        #endregion

    }
}
