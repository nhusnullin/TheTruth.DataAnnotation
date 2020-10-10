using System;

namespace TheTruth.DataAnnotation
{
    /// <summary>
    /// Атрибут для помечания класса, который является моделью SQL таблицы
    /// классы помеченные этим атрибутом становятся доступными для поиска
    /// </summary>
    /// <example>
    /// query {
    ///    tables {
    ///         ...
    ///        }
    ///    }
    /// </example>
    /// <remarks>
    /// 1. Атрибут может применяться для ускорения выгрузки данных утилитой docfx. При условии, что в фильтре указано выгружать лишь этот атрибут
    /// 2. Можно не помечать класс данным атрибутом, если модель используется в DbContext, который в свою очередь помечен атрибутом SqlDatabase.
    /// Т.е. SqlDatabase является глобальным для возможности документирования всей БД
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class SqlTableAttribute : Attribute
    {
    }
}