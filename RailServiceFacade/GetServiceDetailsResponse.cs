﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailServiceFacade
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetServiceDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/types", IsWrapped = true)]
    public partial class GetServiceDetailsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/types", Order = 0)]
        public ServiceDetails GetServiceDetailsResult;

        public GetServiceDetailsResponse()
        {
        }

        public GetServiceDetailsResponse(ServiceDetails GetServiceDetailsResult)
        {
            this.GetServiceDetailsResult = GetServiceDetailsResult;
        }
    }
}
