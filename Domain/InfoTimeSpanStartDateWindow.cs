using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res global info time span start date window.
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
