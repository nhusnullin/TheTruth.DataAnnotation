using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для указания health check url у микросервиса 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class HealthCheckAttribute : HostNameAttribute
    {
        public HealthCheckAttribute(string url) : base(url)
        {
        }

        public HealthCheckAttribute(string url, string name) : base(url, name)
        {
        }
    }
}