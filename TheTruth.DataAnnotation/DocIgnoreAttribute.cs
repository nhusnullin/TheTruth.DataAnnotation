using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атриубт для возможности игнорирования публичных свойств внутри моделей 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DocIgnoreAttribute : Attribute
    {
    }
}