// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Unique Id AKA Bridge Id
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The Unique Id AKA Bridge Id
    /// </summary>
    public class UniqueId
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [XmlAttribute]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [XmlAttribute]
        public string Type { get; set; }

        #endregion
    }
}