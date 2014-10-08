// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile preference collection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile preference collection.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfilePreferenceCollection
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the hotel pref.
        /// </summary>
        public ProfileHotelPreference HotelPref { get; set; }

        #endregion
    }
}