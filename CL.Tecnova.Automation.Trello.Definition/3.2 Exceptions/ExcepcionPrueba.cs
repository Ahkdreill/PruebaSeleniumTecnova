using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Tecnova.Automation.Trello.Definition
{
    public class ExcepcionPrueba : Exception
    {
        #region Constructor de la clase

        /// <summary>
        /// Constructor de la clase sin parámetros
        /// </summary>
        public ExcepcionPrueba()
        {
        }

        /// <summary>
        /// Constructor de la clase con un parámetro.
        /// </summary>
        /// <param name="message">Mensaje</param>
        public ExcepcionPrueba(string message)
        : base(message)
        {
        }

        /// <summary>
        /// Constructor de la clase con dos parámetros.
        /// </summary>
        /// <param name="message">Mensaje</param>
        /// <param name="inner">Excepción</param>
        public ExcepcionPrueba(string message, Exception inner)
        : base(message, inner)
        {
        }

        #endregion
    }
}
