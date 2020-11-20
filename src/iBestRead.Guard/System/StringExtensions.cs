namespace System
{
    /// <summary>
    /// String的扩展方法
    /// </summary>
    public static class StringExtensions
    {
        
        /// <summary>
        /// 判断字符串是否为Null或空
        /// </summary>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        
        /// <summary>
        /// 判断字符串是否为Null,或者为空,又或者全部是空格的字符串
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
        
    }
}