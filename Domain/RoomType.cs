using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
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
