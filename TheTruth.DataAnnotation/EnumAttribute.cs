using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для документирования enum
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class EnumAttribute : Attribute
    {
    }
}