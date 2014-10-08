// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Payment Information Guarantee
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The payment info guarantee.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class PaymentInfoGuarantee
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the guarantees accepted.
        /// </summary>
        public PaymentGuaranteesAccepted GuaranteesAccepted { get; set; }

        #endregion
    }
}