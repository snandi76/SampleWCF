using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace CompanyWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyProvidedPublicServiceClient PubClient = new CompanyService.CompanyProvidedPublicServiceClient("BasicHttpBinding_ICompanyProvidedPublicService");
            Label1.Text = PubClient.CompanyPublicService();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyProvidedConfidentialServiceClient ConClient = new CompanyService.CompanyProvidedConfidentialServiceClient("NetTcpBinding_ICompanyProvidedConfidentialService");
            Label2.Text = ConClient.CompanyConfidentialService();
        }
    }
}