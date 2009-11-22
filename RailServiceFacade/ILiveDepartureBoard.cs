using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RailServiceFacade
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://thalesgroup.com/RTTI/2008-02-20/ldb/", ConfigurationName = "LDBServiceSoap")]
    public interface LDBServiceSoap
    {

        // CODEGEN: Generating message contract since the wrapper namespace (http://thalesgroup.com/RTTI/2008-02-20/ldb/types) of message GetDepartureBoardRequest does not match the default value (http://thalesgroup.com/RTTI/2008-02-20/ldb/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://thalesgroup.com/RTTI/2008-02-20/ldb/GetDepartureBoard", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        GetDepartureBoardResponse GetDepartureBoard(GetDepartureBoardRequest request);

        // CODEGEN: Generating message contract since the wrapper namespace (http://thalesgroup.com/RTTI/2008-02-20/ldb/types) of message GetArrivalBoardRequest does not match the default value (http://thalesgroup.com/RTTI/2008-02-20/ldb/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://thalesgroup.com/RTTI/2008-02-20/ldb/GetArrivalBoard", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        GetArrivalBoardResponse GetArrivalBoard(GetArrivalBoardRequest request);

        // CODEGEN: Generating message contract since the wrapper namespace (http://thalesgroup.com/RTTI/2008-02-20/ldb/types) of message GetArrivalDepartureBoardRequest does not match the default value (http://thalesgroup.com/RTTI/2008-02-20/ldb/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://thalesgroup.com/RTTI/2008-02-20/ldb/GetArrivalDepartureBoard", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        GetArrivalDepartureBoardResponse GetArrivalDepartureBoard(GetArrivalDepartureBoardRequest request);

        // CODEGEN: Generating message contract since the wrapper namespace (http://thalesgroup.com/RTTI/2007-10-10/ldb/types) of message GetServiceDetailsRequest does not match the default value (http://thalesgroup.com/RTTI/2008-02-20/ldb/)
        [System.ServiceModel.OperationContractAttribute(Action = "http://thalesgroup.com/RTTI/2008-02-20/ldb/GetServiceDetails", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        GetServiceDetailsResponse GetServiceDetails(GetServiceDetailsRequest request);
    }

}
