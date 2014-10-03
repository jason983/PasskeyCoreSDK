using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
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
