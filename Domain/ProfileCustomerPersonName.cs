// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Customer Person Name
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile customer person name.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerPersonName
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the given name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        ///     Gets or sets the middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        ///     Gets or sets the name prefix.
        /// </summary>
        public string NamePrefix { get; set; }

        /// <summary>
        ///     Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        #endregion
    }
}