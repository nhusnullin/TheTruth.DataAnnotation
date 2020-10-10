using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для документирования SQL БД
    /// </summary>
    /// <remarks>
    /// Для наименования БД возможно использование разделителя ;
    /// Это бывает удобно когда БД может иметь разные имена на разных средах
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class SqlDatabaseAttribute : Attribute
    {
        public string Name { get; set; }

        /// <summary>
        /// Атрибут для документирования SQL БД
        /// </summary>
        /// <param name="name">Наименование БД (возможно использование разделителя ; для указание больше, чем 1 имени БД)</param>
        public SqlDatabaseAttribute(string name)
        {
            Name = name;
        }
    }
}