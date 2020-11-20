using iBestRead;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    /// Type扩展方法
    /// </summary>
    public static  class TypeExtensions
    {
        public static string GetFullNameWithAssemblyName(this Type type)
        {
            return type.FullName + ", " + type.Assembly.GetName().Name;
        }
        
        public static bool IsAssignableTo<TTarget>([NotNull] this Type type)
        {
            Guard.NotNull(type, nameof(type));

            return type.IsAssignableTo(typeof(TTarget));
        }
        
        public static bool IsAssignableTo([NotNull] this Type type, [NotNull] Type targetType)
        {
            Guard.NotNull(type, nameof(type));
            Guard.NotNull(targetType, nameof(targetType));

            return targetType.IsAssignableFrom(type);
        }
    }
}