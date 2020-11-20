using JetBrains.Annotations;

namespace System.Collections.Generic
{
    /// <summary>
    /// Collection的扩展方法
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Checks whatever given collection object is null or has no item.
        /// </summary>
        public static bool IsNullOrEmpty<T>([CanBeNull] this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }
    }
}