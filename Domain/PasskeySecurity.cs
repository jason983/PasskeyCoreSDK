// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Passkey Security
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The passkey security
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