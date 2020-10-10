using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class HostNameAttribute : Attribute
    {
        public string Url { get; set; }
        public string Name { get; set; }

        public HostNameAttribute(string url)
        {
            Url = url;
        }
        
        public HostNameAttribute(string url, string name)
        {
            Url = url;
            Name = name;
        }
    }
}