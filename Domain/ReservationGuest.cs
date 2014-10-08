// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Reservation Guest
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     A reservation guest.
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