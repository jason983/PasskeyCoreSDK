// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Create Bridge Request Data
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The create bridge request data.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public class CreateBridgeRequestData
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the hotel reservation container.
        /// </summary>
        [XmlElement(Namespace = "http://www.opentravel.org/OTA/2002/11", ElementName = "OTA_HotelResRQ")]
        public HotelReservationContainer HotelReservationContainer { get; set; }

        #endregion
    }
}