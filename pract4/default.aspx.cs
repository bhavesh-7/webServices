using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pract3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ftc_Click(object sender, EventArgs e)
        {
            temp.WebService1SoapClient obj = new temp.WebService1SoapClient();
            double tempF = int.Parse(txttemp.Text);
            double tempC = obj.FahrenheitToCelsius(tempF);
            result.Text = tempF.ToString() + " F To C = " + tempC.ToString();
        }

        protected void ctf_Click(object sender, EventArgs e)
        {
            temp.WebService1SoapClient obj = new temp.WebService1SoapClient();
            double tempF = int.Parse(txttemp.Text);
            double tempC = obj.CelsiusToFahrenheit(tempF);
            result.Text = tempF.ToString() + " F To C = " + tempC.ToString();
        }
    }
}