// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Create Bridge Request
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The create bridge request.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    [XmlRoot(Namespace = "http://www.passkey.com/apiSchema", IsNullable = false, ElementName = "CreateBridgeRQ")]
    public class CreateBridgeRequest
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public CreateBridgeRequestData Data { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public PasskeyMessage Message { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        public PasskeySecurity Security { get; set; }

        #endregion
    }
}