// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Hotel Reservation IDs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The hotel reservation ids
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class HotelReservationIDs
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the hotel reservation id.
        /// </summary>
        public object HotelReservationID { get; set; }

        #endregion
    }
}