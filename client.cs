using System;
using System.Security.Policy;
using System.Threading.Tasks;

namespace SuperPad
{
    internal class client
    {
        public static int MaxResponseContentBufferSize { get; internal set; }

        internal static Task<IDisposable> GetStreamAsync(Url url)
        {
            throw new NotImplementedException();
        }
    }
}