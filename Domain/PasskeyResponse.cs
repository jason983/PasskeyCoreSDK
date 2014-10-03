using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyCoreSDK.Domain
{   
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.passkey.com/apiSchema", IsNullable = false, ElementName="PasskeyRS")]
    public partial class PasskeyResponse
    {

        private ResponseMessage messageField;

        private ResponseData dataField;

        public ResponseMessage Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        public ResponseData Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        public string RequestXML { get; set; }

        public string ResponseXML { get; set; }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema", TypeName = "PasskeyRS")]
    public partial class ResponseMessage
    {

        private ResponseMessageStatus statusField;

        private ResponseMessageErrors errorsField;

        private string gUIDField;

        
        public ResponseMessageStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        
        public ResponseMessageErrors Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ResponseMessageStatus
    {

        private byte idField;

        private string valueField;

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ResponseData
    {

        private ResponseHotelReservationContainer oTA_HotelResRSField;


        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opentravel.org/OTA/2002/11", ElementName = "OTA_HotelResRS")]
        public ResponseHotelReservationContainer ResponseHotelReservationContainer
        {
            get
            {
                return this.oTA_HotelResRSField;
            }
            set
            {
                this.oTA_HotelResRSField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opentravel.org/OTA/2002/11", IsNullable = false)]
    public partial class ResponseHotelReservationContainer
    {

        private ResponseHotelReservations hotelReservationsField;

        
        public ResponseHotelReservations HotelReservations
        {
            get
            {
                return this.hotelReservationsField;
            }
            set
            {
                this.hotelReservationsField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class ResponseHotelReservations
    {

        private ResponseHotelReservation hotelReservationField;

        
        public ResponseHotelReservation HotelReservation
        {
            get
            {
                return this.hotelReservationField;
            }
            set
            {
                this.hotelReservationField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class ResponseHotelReservation
    {

        private ResponseBridgeId uniqueIdField;

        
        public ResponseBridgeId UniqueId
        {
            get
            {
                return this.uniqueIdField;
            }
            set
            {
                this.uniqueIdField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class ResponseBridgeId
    {

        private string idField;

        private string typeField;

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ResponseMessageErrors
    {

        private string errorField;

        
        public string Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }


}
