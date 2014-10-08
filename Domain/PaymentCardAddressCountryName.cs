// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Payment Card Address Country Name
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     Accepted payment card address country name.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class PaymentCardAddressCountryName
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the code.
        /// </summary>
        [XmlAttribute]
        public string Code { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        #endregion
    }
}