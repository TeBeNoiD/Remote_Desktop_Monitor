﻿using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RDMService
{

    public class Service1 : IServiceRDM
    {
        public WSR_Result DownloadData(WSR_Params p)
        {
            throw new NotImplementedException();
        }

        public WSR_Result GetPseudos(WSR_Params p)
        {
            throw new NotImplementedException();
        }

        public WSR_Result Login(WSR_Params p)
        {
            throw new NotImplementedException();
        }

        public WSR_Result Logout(WSR_Params p)
        {
            throw new NotImplementedException();
        }

        public WSR_Result UploadData(WSR_Params p)
        {
            throw new NotImplementedException();
        }
    }
}
