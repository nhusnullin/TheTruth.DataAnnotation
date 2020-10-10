using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class PublicAPIAttribute : Attribute
    {
        public string Url { get; }
        public string Key { get; }

        public PublicAPIAttribute()
        {
            
        }

        public PublicAPIAttribute(string url)
        {
            Url = url;
        }
        
        public PublicAPIAttribute(string url, string key)
        {
            Url = url;
            Key = key;
        }
    }
}