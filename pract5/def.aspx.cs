using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pract4
{
    public partial class def : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            calc.WebService1SoapClient obj = new calc.WebService1SoapClient();
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int res = obj.add(num1, num2);
            result.Text = res.ToString();
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            calc.WebService1SoapClient obj = new calc.WebService1SoapClient();
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int res = obj.sub(num1, num2);
            result.Text = res.ToString();
        }
    }
}