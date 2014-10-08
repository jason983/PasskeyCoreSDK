// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Payment Guarantee Accepted
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The payment guarantee accepted.
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