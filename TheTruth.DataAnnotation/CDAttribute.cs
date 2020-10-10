using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class CDAttribute : HostNameAttribute
    {
        public CDAttribute(string url) : base(url)
        {
        }

        public CDAttribute(string url, string name) : base(url, name)
        {
        }
    }
}