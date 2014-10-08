// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Cancel Bridge Request
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    /// The cancel bridge request.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    [XmlRoot(Namespace = "http://www.passkey.com/apiSchema", IsNullable = false, ElementName = "CancelBridgeRQ")]
    public class CancelBridgeRequest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public CancelBridgeRequestData Data { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        public PasskeyMessage Message { get; set; }

        /// <summary>
        ///     Gets or sets the security.
        /// </summary>
        public PasskeySecurity Security { get; set; }

        #endregion
    }
}