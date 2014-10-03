using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The create bridge rq data.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public class CreateBridgeRequestData
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the hotel reservation request object
        /// </summary>
        [XmlElement(Namespace = "http://www.opentravel.org/OTA/2002/11", ElementName = "OTA_HotelResRQ")]
        public HotelReservationContainer HotelReservationContainer { get; set; }

        #endregion
    }
}
