// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Customer Employee Information
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile customer employee info.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerEmployeeInfo
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the employee title.
        /// </summary>
        [XmlAttribute]
        public string EmployeeTitle { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        #endregion
    }
}