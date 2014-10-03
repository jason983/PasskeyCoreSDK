using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The profile customer.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomer
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        public ProfileCustomerAddress Address { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the employee info.
        /// </summary>
        public ProfileCustomerEmployeeInfo EmployeeInfo { get; set; }

        /// <summary>
        ///     Gets or sets the person name.
        /// </summary>
        public ProfileCustomerPersonName PersonName { get; set; }

        /// <summary>
        ///     Gets or sets the telephone.
        /// </summary>
        [XmlElement("Telephone")]
        public ProfileCustomerTelephone[] Telephone { get; set; }

        #endregion
    }
}
