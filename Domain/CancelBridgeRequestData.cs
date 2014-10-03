using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyCoreSDK.Domain
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema", TypeName = "CancelBridgeRQData")]
    public partial class CancelBridgeRequestData
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opentravel.org/OTA/2002/11", ElementName = "OTA_CancelRQ")]
        public CancelRequest CancelRequest { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opentravel.org/OTA/2002/11", IsNullable = false)]
    public partial class CancelRequest
    {
        /// <remarks/>
        public UniqueId UniqueId { get; set; }
    }
}
