using System.Net.Http;

namespace Synology.Classes
{
    /// <summary>
    /// </summary>
    public class SynologyHttpClient : HttpClient
    {
        /// <summary>
        /// </summary>
        public SynologyHttpClient()
        {
        }

        /// <summary>
        /// </summary>
        public SynologyHttpClient(HttpMessageHandler handler) : base(handler)
        {
        }

        /// <summary>
        /// </summary>
        public SynologyHttpClient(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
        {
        }
    }
}
