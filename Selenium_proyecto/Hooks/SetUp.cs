using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium_proyecto.Hooks
{
    [Binding]
    public class SetUp
    {
        // VARIABLES
        private RemoteWebDriver webDriver;

         public static String ProjectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                                       //Obtiene hasta el Bin - Obtiene la ruta hasta el Visual - retrocede 2 veces-



        //METODOS
        public RemoteWebDriver DeterminarTipoNavegador() //obtener el tipo de navegador
        {   var TagNames = ScenarioContext.Current.ScenarioInfo.Tags;
            if (TagNames.Contains("Chrome"))
            {
                ChromeOptions OpcionesChrome = new ChromeOptions();
                OpcionesChrome.AddArgument("start-maximized");
                webDriver = new ChromeDriver(ProjectPath+"\\Drivers", OpcionesChrome);
            }
            else if (TagNames.Contains("Firefox"))
            {
                webDriver = new FirefoxDriver();
            }
            else if (TagNames.Contains("Edge"))
            {
                webDriver = new EdgeDriver();
            }
            else // Captura el error
            {
                throw new Exception("Tag del navegador no se encontro");
            }
            return webDriver;
        }


        
        //EJECUCION DE ESCENARIOS
        [BeforeScenario]
        public void BeforeScenario()
        {
            webDriver = DeterminarTipoNavegador();
            ScenarioContext.Current.Add("webDriver", webDriver);
        }

    }
}
