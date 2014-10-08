// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Guest Counts
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The guest counts.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class GuestCounts
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the guest count.
        /// </summary>
        public GuestCount GuestCount { get; set; }

        #endregion
    }
}