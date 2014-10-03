using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The create bridge rq security.
    /// </summary>
    public class PasskeySecurity
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the login.
        /// </summary>        
        public PasskeySecurityLogin Login { get; set; }

        /// <summary>
        ///     Gets or sets the partner id.
        /// </summary>
        public uint PartnerID { get; set; }

        /// <summary>
        ///     Gets or sets the token.
        /// </summary>
        public string Token { get; set; }

        #endregion
    }
}
