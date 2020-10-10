using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для документирования NoSQL БД
    /// </summary>
    /// <remarks>
    /// Для наименования БД возможно использование разделителя ;
    /// Это бывает удобно когда БД может иметь разные имена на разных средах
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class NoSqlDatabaseAttribute : Attribute
    {
        public string Name { get; }

        /// <summary>
        /// Атрибут для документирования NoSQL БД
        /// </summary>
        /// <param name="name">Наименование БД (возможно использование разделителя ; для указание больше, чем 1 имени БД)</param>
        public NoSqlDatabaseAttribute(string name)
        {
            Name = name;
        }
    }
}