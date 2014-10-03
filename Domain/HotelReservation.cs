using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The hotel reservation.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class HotelReservation
    {        
        #region Public Properties

        /// <summary>
        ///     Gets or sets the res global info.
        /// </summary>
        public ReservationGlobalInformation ResGlobalInfo { get; set; }

        /// <summary>
        ///     Gets or sets the res guests.
        /// </summary>
        [XmlArray("ResGuests")]
        [XmlArrayItem("ResGuest", IsNullable = false)]
        public ReservationGuest[] ReservationGuests { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether room stay reservation.
        /// </summary>
        [XmlAttribute]
        public bool RoomStayReservation { get; set; }

        /// <summary>
        ///     Gets or sets the room stays.
        /// </summary>
        public RoomStays RoomStays { get; set; }

        /// <summary>
        ///     Gets or sets the tp a_ extensions.
        /// </summary>
        public TPAExtensions TPA_Extensions { get; set; }

        /// <summary>
        ///     Gets or sets the unique id
        /// </summary>
        public UniqueId UniqueId { get; set; }

        #endregion
    }
}
