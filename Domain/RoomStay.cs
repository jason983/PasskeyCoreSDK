// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Room Stay
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The room stay.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class RoomStay
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the guest counts.
        /// </summary>
        public GuestCounts GuestCounts { get; set; }

        /// <summary>
        ///     Gets or sets the room types.
        /// </summary>
        public RoomTypes RoomTypes { get; set; }

        #endregion
    }
}