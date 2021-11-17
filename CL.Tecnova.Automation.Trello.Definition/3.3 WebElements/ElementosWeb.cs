using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CL.Tecnova.Automation.Trello.Definition
{
    public class ElementosWeb
    {
        #region Elementos Web

        [FindsBy(How = How.XPath, Using = "//a[@href='/login'][contains(.,'Iniciar sesión')]")]
        public IWebElement btnIniciarSesion;

        [FindsBy(How = How.XPath, Using = "//input[@id='user']")]
        public IWebElement txtCorreo;

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        public IWebElement txtPassword;

        //[FindsBy(How = How.XPath, Using = "//input[@id='login']")]  
        [FindsBy(How = How.XPath, Using = "(//span[contains(.,'Iniciar sesión')])[2]")]  
        public IWebElement btnLogin;


        [FindsBy(How = How.XPath, Using = "(//input[contains(@id,'login')])[1]")]
        public IWebElement btnLoginSecundario;

        [FindsBy(How = How.XPath, Using = "//p[contains(.,'Este correo electrónico no coincide con el de ninguna cuenta')]")]
        public IWebElement txtMensajeErrorLogin;

        [FindsBy(How = How.XPath, Using = "//span[@class='_13fwAio4RLr1IF'][contains(.,'Tableros')]")]
        public IWebElement btnTablero;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Crear un tablero nuevo')]")]
        public IWebElement btnCrearTableroNuevo;

        [FindsBy(How = How.XPath, Using = "//input[contains(@data-test-id,'create-board-title-input')]")]
        public IWebElement txtTituloTablero;

        [FindsBy(How = How.XPath, Using = "(//button[contains(@type,'button')])[12]")]
        public IWebElement btnCrearTablero;

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'list-header-target js-editing-target')])[1]")]
        public IWebElement btnPrimerTituloLista;

        [FindsBy(How = How.XPath, Using = "(//textarea[contains(@spellcheck,'false')])[1]")]
        public IWebElement txtPrimerTituloLista;

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'list-header-target js-editing-target')])[3]")]
        public IWebElement btnTercerTituloLista;

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@class,'list-header-name mod-list-name js-list-name-input is-editing')]")]
        public IWebElement txtTercerTituloLista;

        [FindsBy(How = How.XPath, Using = "(//div[@class='js-list list-wrapper'])[2]")]
        public IWebElement btnFondoTablero;

        [FindsBy(How = How.XPath, Using = "(//span[contains(.,'Añada una tarjeta')])[1]")]
        public IWebElement btnAgregarTarjeta;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='list-card-composer-textarea js-card-title']")]
        public IWebElement txtTituloTarjeta;

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'nch-button nch-button--primary confirm mod-compact js-add-card')]")]
        public IWebElement btnConfirmarAgregarTarjeta;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div[1]/div/main/div/div[2]/div[2]/div/div[1]/div[3]/div[2]/div[1]/div/div[2]/a/div[3]/span")]
        public IWebElement btnTarjeta;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='field field-autosave js-description-draft description card-description']")]
        public IWebElement txtTarjetaDescripcion;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Etiquetas')]")]
        public IWebElement btnEtiquetaDescripcion;

        [FindsBy(How = How.XPath, Using = "//span[contains(@data-color,'blue')]")]
        public IWebElement btnEtiquetaAzul;

        [FindsBy(How = How.XPath, Using = "//a[@class='pop-over-header-close-btn icon-sm icon-close']")]
        public IWebElement btnCloseEtiqueta;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'_2fqFixbnBCjl76')]")]
        public IWebElement btnEtiquetaFecha;

        [FindsBy(How = How.XPath, Using = "//input[@data-test-id='due-date-field']")]
        public IWebElement txtEtiquetaFecha;

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='save-date-button']")]
        public IWebElement btnEtiquetaFechaGuardar;

        [FindsBy(How = How.XPath, Using = "(//span[contains(@class,'js-sidebar-action-text')])[6]")]
        public IWebElement btnEtiquetaPortada;

        [FindsBy(How = How.XPath, Using = "(//div[@class='photo-attribution-component small'])[1]")]
        public IWebElement btnPortadaImagen;

        [FindsBy(How = How.XPath, Using = "//a[@class='icon-md icon-close dialog-close-button js-close-window dialog-close-button-light']")]
        public IWebElement btnCerrarEtiqueta;

        [FindsBy(How = How.XPath, Using = "(//span[@class='js-sidebar-action-text'])[8]")]
        public IWebElement btnMover;

        [FindsBy(How = How.XPath, Using = "//select[@class='js-select-list']")]
        public IWebElement cboLista;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div[4]/div/div[2]/div/div/div/div/div[2]/div[1]/select/option[2]")]
        public IWebElement optEnProceso;

        [FindsBy(How = How.XPath, Using = "//input[@value='Mover']")]
        public IWebElement btnConfirmarMover;

        [FindsBy(How = How.XPath, Using = "(//span[@class='board-header-btn-text'])[6]")]
        public IWebElement btnMostrarMenu;

        [FindsBy(How = How.XPath, Using = "//a[@class='board-menu-navigation-item-link js-open-more']")]
        public IWebElement btnMas;

        [FindsBy(How = How.XPath, Using = "//a[@class='board-menu-navigation-item-link js-close-board']")]
        public IWebElement btnCerrarTablero;

        [FindsBy(How = How.XPath, Using = "//input[@class='js-confirm full nch-button nch-button--danger']")]
        public IWebElement btnConfirmacionCerrarTablero;

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'close-board-delete-board-button')]")]
        public IWebElement btnEliminarTablero;

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='close-board-delete-board-confirm-button']")]
        public IWebElement btnConfirmacionEliminarTablero;

        [FindsBy(How = How.XPath, Using = "//h3[contains(.,'TUS ESPACIOS DE TRABAJO')]")]
        public IWebElement lblEspacioDeTrabajo;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor predeterminado que inicializa los elementos web.
        /// </summary>
        public ElementosWeb()
        {
            PageFactory.InitElements(PropiedadDriver.GetDriver, this);
        }

        #endregion

    }
}
