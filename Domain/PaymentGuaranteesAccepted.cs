using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res global info guarantee guarantees accepted.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class PaymentGuaranteesAccepted
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the guarantee accepted.
        /// </summary>
        public PaymentGuaranteeAccepted GuaranteeAccepted { get; set; }

        #endregion
    }
}
