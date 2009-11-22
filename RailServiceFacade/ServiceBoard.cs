using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailServiceFacade
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.21006.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/types")]
    public partial class StationBoard
    {

        private System.DateTime generatedAtField;

        private string locationNameField;

        private string crsField;

        private string filterLocationNameField;

        private string filtercrsField;

        private FilterType filterTypeField;

        private NRCCMessage[] nrccMessagesField;

        private bool platformAvailableField;

        private bool areServicesAvailableField;

        private ServiceItem[] trainServicesField;

        private ServiceItem[] busServicesField;

        private ServiceItem[] ferryServicesField;

        public StationBoard()
        {
            this.filterTypeField = FilterType.to;
            this.platformAvailableField = false;
            this.areServicesAvailableField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.DateTime generatedAt
        {
            get
            {
                return this.generatedAtField;
            }
            set
            {
                this.generatedAtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string filterLocationName
        {
            get
            {
                return this.filterLocationNameField;
            }
            set
            {
                this.filterLocationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string filtercrs
        {
            get
            {
                return this.filtercrsField;
            }
            set
            {
                this.filtercrsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute(FilterType.to)]
        public FilterType filterType
        {
            get
            {
                return this.filterTypeField;
            }
            set
            {
                this.filterTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("message")]
        public NRCCMessage[] nrccMessages
        {
            get
            {
                return this.nrccMessagesField;
            }
            set
            {
                this.nrccMessagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool platformAvailable
        {
            get
            {
                return this.platformAvailableField;
            }
            set
            {
                this.platformAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool areServicesAvailable
        {
            get
            {
                return this.areServicesAvailableField;
            }
            set
            {
                this.areServicesAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("service")]
        public ServiceItem[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("service")]
        public ServiceItem[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("service")]
        public ServiceItem[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }

}
