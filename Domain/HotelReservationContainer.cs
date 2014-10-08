// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Hotel Reservation Container
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     Hotel Reservation Container
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [XmlRoot(Namespace = "http://www.opentravel.org/OTA/2002/11", IsNullable = false)]
    public class HotelReservationContainer
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the hotel reservations.
        /// </summary>
        public HotelReservations HotelReservations { get; set; }

        #endregion
    }
}