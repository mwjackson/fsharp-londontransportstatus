using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailServiceFacade
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetDepartureBoardResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/types", IsWrapped = true)]
    public partial class GetDepartureBoardResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/types", Order = 0)]
        public StationBoard GetDepartureBoardResult;

        public GetDepartureBoardResponse()
        {
        }

        public GetDepartureBoardResponse(StationBoard GetDepartureBoardResult)
        {
            this.GetDepartureBoardResult = GetDepartureBoardResult;
        }
    }
}
