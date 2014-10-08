// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Payment Guarantees Accepted
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The payment guarantees accepted.
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