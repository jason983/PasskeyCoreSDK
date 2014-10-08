// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Hotel Reservation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The hotel reservation.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class HotelReservation
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the Reservation Global Inforomation
        /// </summary>
        public ReservationGlobalInformation ResGlobalInfo { get; set; }

        /// <summary>
        ///     Gets or sets the Reservation Guests
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
        ///     Gets or sets the extensions.
        /// </summary>
        public TPAExtensions TPA_Extensions { get; set; }

        /// <summary>
        ///     Gets or sets the unique id
        /// </summary>
        public UniqueId UniqueId { get; set; }

        #endregion
    }
}