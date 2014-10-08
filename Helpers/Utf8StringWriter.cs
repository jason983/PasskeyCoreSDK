// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   UTF-8 String Writer
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Helpers
{
    using System.IO;
    using System.Text;

    /// <summary>
    /// The UTF-8 string writer.
    /// </summary>
    public sealed class Utf8StringWriter : StringWriter
    {
        #region Public Properties

        /// <summary>
        /// Gets the encoding which is defaulted to UTF-8 and cannot be changed.
        /// </summary>
        public override Encoding Encoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }

        #endregion
    }
}