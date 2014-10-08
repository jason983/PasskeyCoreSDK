// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Payment Card
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The payment card.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class PaymentCard
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        public PaymentCardAddress Address { get; set; }

        /// <summary>
        ///     Gets or sets the card code.
        /// </summary>
        [XmlAttribute]
        public string CardCode { get; set; }

        /// <summary>
        ///     Gets or sets the card holder name.
        /// </summary>
        public string CardHolderName { get; set; }

        /// <summary>
        ///     Gets or sets the card number.
        /// </summary>
        [XmlAttribute]
        public ulong CardNumber { get; set; }

        /// <summary>
        ///     Gets or sets the expire date.
        /// </summary>
        [XmlAttribute]
        public ushort ExpireDate { get; set; }

        #endregion
    }
}