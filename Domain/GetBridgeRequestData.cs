// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Get Bridge Request Data
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    /// The get bridge request data.
    /// </summary>
    public class GetBridgeRequestData
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the get request.
        /// </summary>
        [XmlElement(ElementName = "OTA_ReadRQ", Namespace = "http://www.opentravel.org/OTA/2002/11")]
        public GetRequest GetRequest { get; set; }

        #endregion
    }

    /// <summary>
    /// The get request.
    /// </summary>
    public class GetRequest
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the unique id.
        /// </summary>
        public UniqueId UniqueId { get; set; }

        #endregion
    }
}