using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyProvidedService" in both code and config file together.
    public class CompanyProvidedService : ICompanyProvidedPublicService, ICompanyProvidedConfidentialService
    {
        public string CompanyConfidentialService()
        {
            return "This is Company Confidential service inside firewall";
        }

        public string CompanyPublicService()
        {
            return "This is Company Publilc service outside firewall";
        }
    }
}
