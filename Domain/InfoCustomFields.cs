// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Info Custom Fields
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The info custom fields.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class InfoCustomFields
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the custom field 1.
        /// </summary>
        public string CustomField1 { get; set; }

        /// <summary>
        ///     Gets or sets the custom field 2.
        /// </summary>
        public string CustomField2 { get; set; }

        /// <summary>
        ///     Gets or sets the custom field 3.
        /// </summary>
        public string CustomField3 { get; set; }

        /// <summary>
        ///     Gets or sets the custom field 4.
        /// </summary>
        public string CustomField4 { get; set; }

        /// <summary>
        ///     Gets or sets the custom field 5.
        /// </summary>
        public string CustomField5 { get; set; }

        #endregion
    }
}