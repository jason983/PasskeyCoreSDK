using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res global info.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [XmlRoot("ResGlobalInfo")]
    public class ReservationGlobalInformation
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the guarantee.
        /// </summary>
        public PaymentInfoGuarantee Guarantee { get; set; }

        /// <summary>
        ///     Gets or sets the guest counts.
        /// </summary>
        public GuestCounts GuestCounts { get; set; }

        /// <summary>
        ///     Gets or sets the hotel reservation i ds.
        /// </summary>
        public HotelReservationIDs HotelReservationIDs { get; set; }

        /// <summary>
        ///     Gets or sets the memberships.
        /// </summary>
        public object Memberships { get; set; }

        /// <summary>
        ///     Gets or sets the res guest rp hs.
        /// </summary>
        public ReservationGuestRPHs ResGuestRPHs { get; set; }

        /// <summary>
        ///     Gets or sets the time span.
        /// </summary>
        public InfoTimeSpan TimeSpan { get; set; }

        #endregion
    } 
}
