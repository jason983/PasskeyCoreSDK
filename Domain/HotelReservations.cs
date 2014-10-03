using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The hotel reservations.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class HotelReservations
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the hotel reservation.
        /// </summary>
        public HotelReservation HotelReservation { get; set; }

        #endregion
    }
}
