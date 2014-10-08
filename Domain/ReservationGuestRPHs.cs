// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Reservation Guests ?RPHs?
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The reservation guest RPHs.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ReservationGuestRPHs
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the reservation guest RPH.
        /// </summary>
        public object ResGuestRPH { get; set; }

        #endregion
    }
}