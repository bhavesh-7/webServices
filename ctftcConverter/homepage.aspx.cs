using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ctftcConverter
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ttc(object sender, EventArgs e)
        {
            serviceCtctf.WebService1SoapClient obj = new serviceCtctf.WebService1SoapClient();
            double tempF = int.Parse(tempIn.Text);
            double tempC = obj.stf(tempF);
            outputTemp.Text = tempF.ToString() + " F To C = " + tempC.ToString();
        }
        protected void ttf(object sender, EventArgs e)
        {
            serviceCtctf.WebService1SoapClient obj = new serviceCtctf.WebService1SoapClient();
            double tempC = int.Parse(tempIn.Text);
            double tempF = obj.stc(tempC);
            outputTemp.Text = tempC.ToString() + " C To F = " +tempF.ToString();
        }

        protected void calc(object sender, EventArgs e)
        {
            serviceadd.WebService1SoapClient obj = new serviceadd.WebService1SoapClient();
            double num1 = double.Parse(num1in.Text);
            double num2 = double.Parse(num2in.Text);
            double res = 0;  // Initialize the result

            if (sender == add)
            {
                res = obj.sadd(num1, num2);
            }
            else if (sender == sub)
            {
                res = obj.ssub(num1, num2);
            }
            else if (sender == mul)
            {
                res = obj.smul(num1, num2);
            }
            else if (sender == div)
            {
                res = obj.sdiv(num1, num2);
            }
            else if (sender == mod)
            {
                res = obj.smod(num1, num2);
            }

            outArth.Text = res.ToString();
        }

    }
}