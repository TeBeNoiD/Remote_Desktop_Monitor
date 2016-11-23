using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsumeWebServiceRest;
using RDMService;

namespace UnitTestRDMService
{
    [TestClass]
    public class UnitTestService
    {
        [TestMethod]
        public void TestVerifParamExistOK()
        {
            WSR_Params p = new WSR_Params();
            string key = "paramString";
            string param = "essai";
            object data = null;
            p.Add(key, param);

            WSR_Result rExpected = new WSR_Result();
            rExpected = null;

            ServiceForUnitTest service = new ServiceForUnitTest();
            WSR_Result rActual = new WSR_Result();
            rActual = service.VerifParamExistTest<string>(p, key, out data);

            Assert.AreEqual(rExpected, rActual);
        }

        [TestMethod]
        public void TestVerifParamExistNotOK()
        {
            WSR_Params p = new WSR_Params();
            string key = "paramString";
            string param = "essai";
            object data = null;
            p.Add(key, param);

            WSR_Result rExpected = new WSR_Result();
            rExpected = null;

            ServiceForUnitTest service = new ServiceForUnitTest();
            WSR_Result rActual = new WSR_Result();
            rActual = service.VerifParamExistTest<string>(p, "paramKo", out data);

            Assert.AreNotEqual(rExpected, rActual);
        }

        [TestMethod]
        public void TestVerifParamTypeOK()
        {
            WSR_Params p = new WSR_Params();
            string key = "paramString";
            string param = "essai";
            string value = null;
            p.Add(key, param);

            WSR_Result rExpected = new WSR_Result();
            rExpected = null;

            ServiceForUnitTest service = new ServiceForUnitTest();
            WSR_Result rActual = new WSR_Result();
            rActual = service.VerifParamTypeTest(p, key, out value);

            Assert.AreEqual(rExpected, rActual);
        }
    }
}
