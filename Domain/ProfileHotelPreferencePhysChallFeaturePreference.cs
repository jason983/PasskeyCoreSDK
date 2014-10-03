using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res guest profiles profile info profile pref collections pref collection hotel pref phys chall feature pref.
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
