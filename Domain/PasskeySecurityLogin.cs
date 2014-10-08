// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Passkey Security Login
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The Passkey security login
    /// </summary>
    public class PasskeySecurityLogin
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///     Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        #endregion
    }
}