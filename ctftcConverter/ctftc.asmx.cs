using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ctftcConverter
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

        [WebMethod]
        public double stc(double ct)
        {
            return ct * 1.8 + 32;
        }
        [WebMethod]
        public double stf(double tf)
        {
            return ((tf - 32) / 1.8);
        }
        [WebMethod]
        public double sadd(double num1 , double num2)
        {
            return num1+num2;
        }
        [WebMethod]
        public double ssub(double num1, double num2)
        {
            return num1 - num2;
        }
        [WebMethod]
        public double smul(double num1, double num2)
        {
            return num1 * num2;
        }
        [WebMethod]
        public double sdiv(double num1, double num2)
        {
            return num1 / num2;
        }
        [WebMethod]
        public double smod(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
