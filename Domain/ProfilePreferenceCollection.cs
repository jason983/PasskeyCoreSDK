using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res guest profiles profile info profile pref collections pref collection.
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
