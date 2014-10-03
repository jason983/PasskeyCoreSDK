using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res guest profiles profile info profile customer telephone.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerTelephone
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the phone number.
        /// </summary>
        [XmlAttribute]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     Gets or sets the phone tech type.
        /// </summary>
        [XmlAttribute]
        public byte PhoneTechType { get; set; }

        #endregion
    }
}
