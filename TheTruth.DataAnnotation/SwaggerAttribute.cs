using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для возможности документировать url до swagger описания API
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class SwaggerAttribute: HostNameAttribute
    {
        public SwaggerAttribute(string url) : base(url)
        {
        }

        public SwaggerAttribute(string url, string name) : base(url, name)
        {
        }
    }
}