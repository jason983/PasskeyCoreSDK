// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Request Data to Cancel a Bridge Record
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The cancel bridge request data.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema", TypeName = "CancelBridgeRQData")]
    public class CancelBridgeRequestData
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the cancel request.
        /// </summary>
        [XmlElement(Namespace = "http://www.opentravel.org/OTA/2002/11", ElementName = "OTA_CancelRQ")]
        public CancelRequest CancelRequest { get; set; }

        #endregion
    }

    /// <summary>
    /// The cancel request.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [XmlRoot(Namespace = "http://www.opentravel.org/OTA/2002/11", IsNullable = false)]
    public class CancelRequest
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the unique id.
        /// </summary>
        public UniqueId UniqueId { get; set; }

        #endregion
    }
}