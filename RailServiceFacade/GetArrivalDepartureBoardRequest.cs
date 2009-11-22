using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailServiceFacade
{

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetArrivalDepartureBoardRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/types", IsWrapped = true)]
    public partial class GetArrivalDepartureBoardRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/types", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/types", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/types", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/types", Order = 3)]
        [System.ComponentModel.DefaultValueAttribute(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/types", Order = 4)]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int timeOffset;

        public GetArrivalDepartureBoardRequest()
        {
        }

        public GetArrivalDepartureBoardRequest(ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset)
        {
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
        }
    }

}
