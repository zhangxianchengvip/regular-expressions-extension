using System.Collections.Generic;

namespace System.Text.RegularExpressions
{
    public static class NumberRegularExpressionsExtension
    {
        // 1 数字：^[0-9]*$
        private readonly static string _numberPattern = "^(\\-|\\+)?\\d+(\\.\\d+)?$";

        /// <summary>
        /// 输入字符串是否是数字
        /// </summary>
        /// <param name="regex">正则表达式</param>
        /// <param name="input">输入</param>
        /// <returns></returns>
        public static bool IsNumber(this string input)
        {
            return Regex.IsMatch(input, _numberPattern);
        }
    }
}
