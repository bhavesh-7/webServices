using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace pract2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //temp calc
        [WebMethod]
        public double FahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * 5 / 9;
        }

        [WebMethod]
        public double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }



        //simplecalc
        [WebMethod]
        public int add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int sub(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public int mul(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public string div(int a, int b)
        {
            if (b == 0)
            {
                return "division form denomi 0 in invalid";
            }
            else
            {
                int div = a / b;
                return div.ToString();
            }
        }

        [WebMethod]
        public int mod(int a, int b)
        {
            return a % b;
        }
    }
}
