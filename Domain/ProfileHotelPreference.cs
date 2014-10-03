using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res guest profiles profile info profile pref collections pref collection hotel pref.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileHotelPreference
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the phys chall feature pref.
        /// </summary>
        public ProfileHotelPreferencePhysChallFeaturePreference PhysChallFeaturePref { get; set; }

        /// <summary>
        ///     Gets or sets the smoking allowed.
        /// </summary>
        [XmlAttribute]
        public byte SmokingAllowed { get; set; }

        /// <summary>
        ///     Gets or sets the spec request pref.
        /// </summary>
        public string SpecRequestPref { get; set; }

        #endregion
    }
}
