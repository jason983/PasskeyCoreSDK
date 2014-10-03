using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The res guest.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]    
    public class ReservationGuest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the profiles.
        /// </summary>
        public Profiles Profiles { get; set; }

        /// <summary>
        ///     Gets or sets the res guest rph.
        /// </summary>
        [XmlAttribute("ResGuestRPH")]
        public byte ReservationGuestRPH { get; set; }

        #endregion
    }
}
