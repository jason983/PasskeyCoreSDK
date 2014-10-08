// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Preference Collections
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile preference collections.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfilePreferenceCollections
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the pref collection.
        /// </summary>
        public ProfilePreferenceCollection PrefCollection { get; set; }

        #endregion
    }
}