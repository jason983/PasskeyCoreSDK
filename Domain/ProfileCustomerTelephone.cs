// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Customer Telephone
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile customer telephone.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerTelephone
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the phone number.
        /// </summary>
        [XmlAttribute]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     Gets or sets the phone tech type.
        /// </summary>
        [XmlAttribute]
        public byte PhoneTechType { get; set; }

        #endregion
    }
}