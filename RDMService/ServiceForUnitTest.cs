using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDMService
{
    /// <summary>
    /// Classe héritant de Service, permet d'appeler ces méthodes (public) pour les tests unitaires
    /// </summary>
    public class ServiceForUnitTest : Service
    {
        public WSR_Result VerifParamTypeTest<T>(WSR_Params p, string key, out T value) where T : class
        {
            return VerifParamType(p, key, out value);
        }

        public WSR_Result VerifParamExistTest<T>(WSR_Params p, string key, out object data)
        {
            return VerifParamExist(p, key, out data);
        }
    }
}