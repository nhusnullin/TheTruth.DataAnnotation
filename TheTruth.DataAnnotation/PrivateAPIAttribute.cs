using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class PrivateAPIAttribute : Attribute
    {
        public string Url { get; }
        public string Key { get; }

        public PrivateAPIAttribute()
        {
            
        }

        public PrivateAPIAttribute(string url)
        {
            Url = url;
        }
        
        public PrivateAPIAttribute(string url, string key)
        {
            Url = url;
            Key = key;
        }
    }
}