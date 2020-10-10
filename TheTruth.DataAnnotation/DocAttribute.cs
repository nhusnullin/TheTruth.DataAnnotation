using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Общий атрибут для документирования тех частей проекта, для которых не созданы специальные атрибуты 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
    public class DocAttribute : Attribute
    {
    }
}