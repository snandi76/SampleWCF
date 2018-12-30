using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompanyProvidedService" in both code and config file together.
    [ServiceContract]
    public interface ICompanyProvidedPublicService
    {
        [OperationContract]
        string CompanyPublicService();
    }

    [ServiceContract]
    public interface ICompanyProvidedConfidentialService
    {
        [OperationContract]
        string CompanyConfidentialService();
    }
}
