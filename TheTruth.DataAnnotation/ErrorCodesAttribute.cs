using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для документирования кодов ошибок
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class ErrorCodesAttribute : Attribute
    {
    }
}