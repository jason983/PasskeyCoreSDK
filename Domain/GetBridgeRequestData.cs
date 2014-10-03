using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyCoreSDK.Domain
{
    /// <remarks/>
    public partial class GetBridgeRequestData
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "OTA_ReadRQ", Namespace = "http://www.opentravel.org/OTA/2002/11")]
        public GetRequest GetRequest { get; set; }
    }

    /// <remarks/>
    public partial class GetRequest
    {
        /// <remarks/>
        public UniqueId UniqueId { get; set; }
    }
}
