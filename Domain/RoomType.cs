// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Room Type
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The room type.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class RoomType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the number of units.
        /// </summary>
        [XmlAttribute]
        public byte NumberOfUnits { get; set; }

        #endregion
    }
}