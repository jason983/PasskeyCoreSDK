// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Room Stays
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The room stays.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class RoomStays
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the room stay.
        /// </summary>
        public RoomStay RoomStay { get; set; }

        #endregion
    }
}