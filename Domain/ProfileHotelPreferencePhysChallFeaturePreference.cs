// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile Hotel Preference Phys Chall Feature Preference
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The Profile Hotel Preference Phys Chall Feature Preference
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileHotelPreferencePhysChallFeaturePreference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the phys chall feature.
        /// </summary>
        [XmlAttribute]
        public byte PhysChallFeature { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        [XmlText]
        public byte Value { get; set; }

        #endregion
    }
}