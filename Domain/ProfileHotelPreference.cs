// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile hotel preferences
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile hotel preferences
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileHotelPreference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the physically challenged feature preference.
        /// </summary>
        public ProfileHotelPreferencePhysChallFeaturePreference PhysChallFeaturePref { get; set; }

        /// <summary>
        ///     Gets or sets the smoking allowed.
        /// </summary>
        [XmlAttribute]
        public byte SmokingAllowed { get; set; }

        /// <summary>
        ///     Gets or sets the special request preference.
        /// </summary>
        public string SpecRequestPref { get; set; }

        #endregion
    }
}