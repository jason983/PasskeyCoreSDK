// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   TPA Extension PK Information
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The TPA Extension PK Information
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class TPAExtensionsPKInfo
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the attendee code.
        /// </summary>
        public string AttendeeCode { get; set; }

        /// <summary>
        ///     Gets or sets the bill phone.
        /// </summary>
        public BillingPhoneNumber BillPhone { get; set; }

        /// <summary>
        ///     Gets or sets the block id.
        /// </summary>
        public uint BlockID { get; set; }

        /// <summary>
        ///     Gets or sets the custom fields.
        /// </summary>
        public InfoCustomFields CustomFields { get; set; }

        /// <summary>
        ///     Gets or sets the event id.
        /// </summary>
        public uint EventID { get; set; }

        /// <summary>
        ///     Gets or sets the ext reference id.
        /// </summary>
        public string ExtReferenceID { get; set; }

        /// <summary>
        ///     Gets or sets the how booked.
        /// </summary>
        public byte HowBooked { get; set; }

        /// <summary>
        ///     Gets or sets the payment type.
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        ///     Gets or sets the primary guest rph.
        /// </summary>
        public byte PrimaryGuestRPH { get; set; }

        /// <summary>
        ///     Gets or sets the received from.
        /// </summary>
        public string ReceivedFrom { get; set; }

        /// <summary>
        ///     Gets or sets the referrer.
        /// </summary>
        public string Referrer { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether send ack.
        /// </summary>
        public bool SendAck { get; set; }

        #endregion
    }
}