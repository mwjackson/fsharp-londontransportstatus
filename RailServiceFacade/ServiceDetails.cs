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
    public partial class ServiceDetails
    {

        private System.DateTime generatedAtField;

        private ServiceType serviceTypeField;

        private string locationNameField;

        private string crsField;

        private string operatorField;

        private string operatorCodeField;

        private bool isCancelledField;

        private string disruptionReasonField;

        private string overdueMessageField;

        private string platformField;

        private string staField;

        private string etaField;

        private string ataField;

        private string stdField;

        private string etdField;

        private string atdField;

        private CallingPoint[][] previousCallingPointsField;

        private CallingPoint[][] subsequentCallingPointsField;

        public ServiceDetails()
        {
            this.isCancelledField = false;
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
        public ServiceType serviceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string operatorCode
        {
            get
            {
                return this.operatorCodeField;
            }
            set
            {
                this.operatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isCancelled
        {
            get
            {
                return this.isCancelledField;
            }
            set
            {
                this.isCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string disruptionReason
        {
            get
            {
                return this.disruptionReasonField;
            }
            set
            {
                this.disruptionReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string overdueMessage
        {
            get
            {
                return this.overdueMessageField;
            }
            set
            {
                this.overdueMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string sta
        {
            get
            {
                return this.staField;
            }
            set
            {
                this.staField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string eta
        {
            get
            {
                return this.etaField;
            }
            set
            {
                this.etaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string ata
        {
            get
            {
                return this.ataField;
            }
            set
            {
                this.ataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string std
        {
            get
            {
                return this.stdField;
            }
            set
            {
                this.stdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string etd
        {
            get
            {
                return this.etdField;
            }
            set
            {
                this.etdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string atd
        {
            get
            {
                return this.atdField;
            }
            set
            {
                this.atdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 16)]
        [System.Xml.Serialization.XmlArrayItemAttribute("callingPointList")]
        [System.Xml.Serialization.XmlArrayItemAttribute("callingPoint", NestingLevel = 1)]
        public CallingPoint[][] previousCallingPoints
        {
            get
            {
                return this.previousCallingPointsField;
            }
            set
            {
                this.previousCallingPointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 17)]
        [System.Xml.Serialization.XmlArrayItemAttribute("callingPointList")]
        [System.Xml.Serialization.XmlArrayItemAttribute("callingPoint", NestingLevel = 1)]
        public CallingPoint[][] subsequentCallingPoints
        {
            get
            {
                return this.subsequentCallingPointsField;
            }
            set
            {
                this.subsequentCallingPointsField = value;
            }
        }
    }
}
