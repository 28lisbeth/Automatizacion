using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_proyecto.Page
{

    class BusquedaPage : BasePage
    {
        RemoteWebDriver _webdriver;

        public void NavegarUrls ()
        {
            _webdriver = base.webDriver;
        }

        #region ELEMENTOS DE LA PAGINA
        By TXT_BUSQUEDA = By.Id("search_query_top");
        By BTN_BUSQUEDA = By.Name("submit_search");
        #endregion

        #region METODOS DE LA PAGINA
        public void IngresarTextoBusqueda(String text)
        {
            sendText(TXT_BUSQUEDA, text);
        }
        public void ClicBotonBusqueda()
        {
            doClic(BTN_BUSQUEDA);
        }
        #endregion
       



    }
}
