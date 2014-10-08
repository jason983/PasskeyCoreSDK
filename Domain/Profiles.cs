// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profiles
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profiles.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class Profiles
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the profile info.
        /// </summary>
        public ProfileInfo ProfileInfo { get; set; }

        #endregion
    }
}