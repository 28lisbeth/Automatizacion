using Selenium_proyecto.Page;
using System;
using TechTalk.SpecFlow;

namespace Selenium_proyecto
{


    [Binding]
    public class Selenium_ProyectoSteps
    {
        BusquedaPage busquedaPage = new BusquedaPage();
        AgregarVestidosComparePage agregarVestidosComparePage = new AgregarVestidosComparePage();

        [Given(@"el usuario navega a la url ""(.*)""")]
        public void GivenElUsuarioNavegaALaUrl(string url)
        {
            busquedaPage.navegarUrlBase(url);
        }
        
        [When(@"el usuario ingresa la palabra ""(.*)"" en la unica caja de texto de busqueda")]
        public void WhenElUsuarioIngresaLaPalabraEnLaUnicaCajaDeTextoDeBusqueda(string text)
        {
            busquedaPage.IngresarTextoBusqueda(text);
        }
        
        [When(@"el usuario hace click en el boton de buscar producto")]
        public void WhenElUsuarioHaceClickEnElBotonDeBuscarProducto()
        {
            busquedaPage.ClicBotonBusqueda();
        }
        
        [When(@"el usuario sobrepone el mouse en el  PRIMER vestido deseado")]
        public void WhenElUsuarioSobreponeElMouseEnElPRIMERVestidoDeseado()
        {
          
        }
        
        [When(@"el usuario agrega al PRIMER vestido a la opción compare")]
        public void WhenElUsuarioAgregaAlPRIMERVestidoALaOpcionCompare()
        {
           agregarVestidosComparePage.HacerClicCompare1();
        }
        
        [When(@"el usuario sobrepone el mouse en el  SEGUNDO vestido deseado")]
        public void WhenElUsuarioSobreponeElMouseEnElSEGUNDOVestidoDeseado()
        {
           
        }
        
        [When(@"el usuario agrega al SEGUNDO vestido a la opción compare")]
        public void WhenElUsuarioAgregaAlSEGUNDOVestidoALaOpcionCompare()
        {
          //  agregarVestidosComparePage.HacerClicCompare2();
        }

        [When(@"el usuario hace click en el boton de comparar")]
        public void WhenElUsuarioHaceClickEnElBotonDeComparar()
        {
           // agregarVestidosComparePage.HacerClicBotonCompare();
        }

        [Then(@"Verificar que el PRIMER vestido sea su precio ""(.*)"" dolares")]
        public void ThenVerificarQueElPRIMERVestidoSeaSuPrecioDolares(Decimal p0)
        {
            
        }
        
        [Then(@"Verificar que el SEGUNDO vestido sea su precio ""(.*)"" dolares")]
        public void ThenVerificarQueElSEGUNDOVestidoSeaSuPrecioDolares(Decimal p0)
        {
            
        }
    }
}
