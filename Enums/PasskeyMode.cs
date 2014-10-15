// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The mode that will determine the configuration of the Passkey web service. (Traning, QA, Production)
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Enums
{
    /// <summary>
    /// The passkey mode.
    /// </summary>
    public enum PasskeyMode
    {
        /// <summary>
        /// Certification Mode
        /// </summary>
        Training = 1, 

        /// <summary>
        /// QA Mode
        /// </summary>
        QA = 2, 

        /// <summary>
        /// Production Mode
        /// </summary>
        Production = 3
    }
}