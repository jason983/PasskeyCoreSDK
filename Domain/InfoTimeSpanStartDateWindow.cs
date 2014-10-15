// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Info Time Span Start Date Window
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    ///     The info time span start date window.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class InfoTimeSpanStartDateWindow
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the earliest date.
        /// </summary>
        [XmlAttribute(DataType = "date")]
        public DateTime EarliestDate { get; set; }

        /// <summary>
        ///     Gets or sets the latest date.
        /// </summary>
        [XmlAttribute(DataType = "date")]
        public DateTime LatestDate { get; set; }

        #endregion
    }
}