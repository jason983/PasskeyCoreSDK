// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   TPA Extensions
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The TPA Extensions
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class TPAExtensions
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the PK info.
        /// </summary>
        public TPAExtensionsPKInfo PK_Info { get; set; }

        #endregion
    }
}