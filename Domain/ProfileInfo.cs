// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Information
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile info.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileInfo
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the profile.
        /// </summary>
        public Profile Profile { get; set; }

        #endregion
    }
}