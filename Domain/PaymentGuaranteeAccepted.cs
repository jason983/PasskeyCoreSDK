using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PasskeyCoreSDK.Domain;

namespace PasskeyCoreSDK
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res global info guarantee guarantees accepted guarantee accepted.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class PaymentGuaranteeAccepted
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the payment card.
        /// </summary>
        public PaymentCard PaymentCard { get; set; }

        #endregion
    }
}
