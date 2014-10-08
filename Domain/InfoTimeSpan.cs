// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Information Time Span
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The info time span.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class InfoTimeSpan
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the start date window.
        /// </summary>
        public InfoTimeSpanStartDateWindow StartDateWindow { get; set; }

        #endregion
    }
}