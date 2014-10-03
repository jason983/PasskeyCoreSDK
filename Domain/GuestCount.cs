using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The guest count.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class GuestCount
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the age qualifying code.
        /// </summary>
        [XmlAttribute]
        public byte AgeQualifyingCode { get; set; }

        /// <summary>
        ///     Gets or sets the count.
        /// </summary>
        [XmlAttribute]
        public byte Count { get; set; }

        #endregion
    }
}
