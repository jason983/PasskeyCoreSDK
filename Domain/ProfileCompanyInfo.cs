// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Company Information
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile company info.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCompanyInfo
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the company name.
        /// </summary>
        public string CompanyName { get; set; }

        #endregion
    }
}