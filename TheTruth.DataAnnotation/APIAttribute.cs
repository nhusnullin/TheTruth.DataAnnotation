using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class APIAttribute : Attribute
    {
        public string Url { get; }
        public string Key { get; }

        public APIAttribute()
        {
            
        }

        public APIAttribute(string url)
        {
            Url = url;
        }
        
        public APIAttribute(string url, string key)
        {
            Url = url;
            Key = key;
        }
    }
}