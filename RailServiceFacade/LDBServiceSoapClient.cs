using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailServiceFacade
{

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LDBServiceSoapClient : System.ServiceModel.ClientBase<LDBServiceSoap>, LDBServiceSoap
    {

        public LDBServiceSoapClient()
        {
        }

        public LDBServiceSoapClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public LDBServiceSoapClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public LDBServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public LDBServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetDepartureBoardResponse LDBServiceSoap.GetDepartureBoard(GetDepartureBoardRequest request)
        {
            return base.Channel.GetDepartureBoard(request);
        }

        public StationBoard GetDepartureBoard(ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset)
        {
            GetDepartureBoardRequest inValue = new GetDepartureBoardRequest();
            inValue.numRows = numRows;
            inValue.crs = crs;
            inValue.filterCrs = filterCrs;
            inValue.filterType = filterType;
            inValue.timeOffset = timeOffset;
            GetDepartureBoardResponse retVal = ((LDBServiceSoap)(this)).GetDepartureBoard(inValue);
            return retVal.GetDepartureBoardResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetArrivalBoardResponse LDBServiceSoap.GetArrivalBoard(GetArrivalBoardRequest request)
        {
            return base.Channel.GetArrivalBoard(request);
        }

        public StationBoard GetArrivalBoard(ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset)
        {
            GetArrivalBoardRequest inValue = new GetArrivalBoardRequest();
            inValue.numRows = numRows;
            inValue.crs = crs;
            inValue.filterCrs = filterCrs;
            inValue.filterType = filterType;
            inValue.timeOffset = timeOffset;
            GetArrivalBoardResponse retVal = ((LDBServiceSoap)(this)).GetArrivalBoard(inValue);
            return retVal.GetArrivalBoardResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetArrivalDepartureBoardResponse LDBServiceSoap.GetArrivalDepartureBoard(GetArrivalDepartureBoardRequest request)
        {
            return base.Channel.GetArrivalDepartureBoard(request);
        }

        public StationBoard GetArrivalDepartureBoard(ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset)
        {
            GetArrivalDepartureBoardRequest inValue = new GetArrivalDepartureBoardRequest();
            inValue.numRows = numRows;
            inValue.crs = crs;
            inValue.filterCrs = filterCrs;
            inValue.filterType = filterType;
            inValue.timeOffset = timeOffset;
            GetArrivalDepartureBoardResponse retVal = ((LDBServiceSoap)(this)).GetArrivalDepartureBoard(inValue);
            return retVal.GetArrivalDepartureBoardResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetServiceDetailsResponse LDBServiceSoap.GetServiceDetails(GetServiceDetailsRequest request)
        {
            return base.Channel.GetServiceDetails(request);
        }

        public ServiceDetails GetServiceDetails(string serviceID)
        {
            GetServiceDetailsRequest inValue = new GetServiceDetailsRequest();
            inValue.serviceID = serviceID;
            GetServiceDetailsResponse retVal = ((LDBServiceSoap)(this)).GetServiceDetails(inValue);
            return retVal.GetServiceDetailsResult;
        }
    }

}
