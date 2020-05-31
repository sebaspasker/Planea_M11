using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace library.UTILS {
    public class WebScraping {
        public static List<string> GetCatalogoUrls(string nombre_plan, string ciudad, int max)
        {
            List<string> urls = new List<string>();
            for(int i = 1; i <= max; i++)
            {
                urls.Add($@"https://www.yelp.es/search?find_desc=" + nombre_plan + "&find_loc=" + ciudad + "&ns=1&start=" + i + "0");
            }

            return urls;
        }

        public static IWebDriver GetDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //Descomenta ela siguiente linea para usar el mode headless de Chrome
            //options.AddArgument("--headless"); 
            options.AddArgument("--disable-gpu");
            options.AddArgument("test-type");
            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
            return driver;
        }
        
        public static List<ENPlanes> scrap(IWebDriver driver, string ciudad, string categoria)
        {

            List<ENPlanes> planes = new List<ENPlanes>();
            var chromeDriver = driver;
            List<string> urls = GetCatalogoUrls(categoria, ciudad, 1);
            string className = "lemon--a__373c0__IEZFH link__373c0__1G70M link-color--inherit__373c0__3dzpk link-size--inherit__373c0__1VFlE";
            string classPrice = "lemon--span__373c0__3997G text__373c0__2Kxyz priceRange__373c0__2DY87 text-color--black-extra-light__373c0__2OyzO text-align--left__373c0__2XGa- text-bullet--after__373c0__3fS1Z";
            foreach(var url in urls)
            {
                chromeDriver.Navigate().GoToUrl(url);
                var titles = chromeDriver.FindElements(By.CssSelector("div > div > div > div > div > div > div > div > div > div > h4 > span > a, [class=\"" + className + "\"]"));
                var prices = chromeDriver.FindElements(By.CssSelector("li > div > div > div > div > div > div > div > div > div > div > div > div > div > div > " +
                    "span > span, [class=\"" + classPrice + "\"]"));

                int tam = Math.Min(titles.Count, prices.Count);
                for(int i=0; i<tam; i++)
                {
                    ENPlanes plan = new ENPlanes();
                    plan.Nombre = titles[i].Text;
                    plan.Categoria = categoria;
                    plan.Ciudad = ciudad;
                    if(prices[i].Text == "€")
                    {
                        plan.Precio = 10;
                    } 
                    else if(prices[i].Text == "€€")
                    {
                        plan.Precio = 20;
                    }
                    else if(prices[i].Text == "€€€")
                    {
                        plan.Precio = 30;
                    }
                    else if(prices[i].Text == "€€€€")
                    {
                        plan.Precio = 40;
                    }
                    else
                    {
                        plan.Precio = 0;
                    }
                    planes.Add(plan);
                }
            }

            chromeDriver.Close();
            return planes;
        }
    }
}
