using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res guest profiles profile info profile customer employee info.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerEmployeeInfo
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the employee title.
        /// </summary>
        [XmlAttribute]
        public string EmployeeTitle { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        #endregion
    }
}
