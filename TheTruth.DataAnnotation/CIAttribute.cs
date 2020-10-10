using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    ///  
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class CIAttribute : HostNameAttribute
    {
        public CIAttribute(string url) : base(url)
        {
        }

        public CIAttribute(string url, string name) : base(url, name)
        {
        }
    }
}