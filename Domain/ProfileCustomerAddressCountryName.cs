// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Customer Address Country Name
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile customer address country name.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerAddressCountryName
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the code.
        /// </summary>
        [XmlAttribute]
        public string Code { get; set; }

        #endregion
    }
}