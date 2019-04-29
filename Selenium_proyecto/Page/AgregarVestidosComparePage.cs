using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace Selenium_proyecto.Page
{
    class AgregarVestidosComparePage : BasePage
    {
        RemoteWebDriver _webDriver;
        public void NavegarUrls()
        {
            _webDriver = base.webDriver;
        }

        #region ELEMENTOS DE LA PAGINA
        By PRIMER_VESTIDO = By.ClassName("");
        By LINK_COMPARE1 = By.XPath("//div[@class='compare']//a[@data-id-product='3']");
        By SEGUNDO_VESTIDO = By.ClassName("");
        By LINK_COMPARE2 = By.XPath("//div[@class='compare']//a[@data-id-product='3']");
        By BTN_COMPARE = By.ClassName("btn btn-default button button-medium bt_compare bt_compare");
        #endregion

        #region METODOS DE LA PAGINA
        public void PonerMousePrimerVestido1()
        { }

        public void HacerClicCompare1()
        {
            Thread.Sleep(6000);
            doClic(LINK_COMPARE1);
        }
        public void PonerMousePrimerVestido2()
        { }

        public void HacerClicCompare2()
        {
            doClic(LINK_COMPARE2);
        }

        public void HacerClicBotonCompare()
        {
            doClic(BTN_COMPARE);
        }

        #endregion





    }
}
