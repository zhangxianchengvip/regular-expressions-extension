namespace System.Text.RegularExpressions
{
    public static class SpecialRegularExpressionsExtension
    {
        /// <summary>
        /// email pattern
        /// </summary>
        private readonly static string _emailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        /// <summary>
        /// phone pattern
        /// </summary>
        private readonly static string _phonePattern = @"^(13[0-9]|14[0-9]|15[0-9]|16[0-9]|17[0-9]|18[0-9]|19[0-9])\d{8}$";

        /// <summary>
        /// url pattern
        /// </summary>
        private readonly static string _urlPattern = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";

        /// <summary>
        /// domain name pattern
        /// </summary>
        private readonly static string _domainNamePattern = @"[a-zA-Z0-9][-a-zA-Z0-9]{0,62}(/.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+/.?";

        /// <summary>
        /// identity card pattern
        /// </summary>
        private readonly static string _identiyCardPattern = @"^((\d{18})|([0-9x]{18})|([0-9X]{18}))$";

        /// <summary>
        /// ip pattern
        /// </summary>
        private readonly static string _ipPattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        /// <summary>
        /// qq pattern
        /// </summary>
        private readonly static string _qqPattern = @"^[1-9]{1}[0-9]{4,14}$";

        /// <summary>
        /// date time pattern
        /// </summary>
        private readonly static string _dateTimePattern = @"^\d{4}-\d{1,2}-\d{1,2}";

        /// <summary>
        /// 输入字符串是否是email
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsEmail(this string input)
        {

            return Regex.IsMatch(input, _emailPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 输入字符串是否是phone
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPhone(this string input)
        {
            return Regex.IsMatch(input, _phonePattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// // 输入字符串是否是url
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsUrl(this string input)
        {
            return Regex.IsMatch(input, _urlPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 输入字符串是否是domain name
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsDomainName(this string input)
        {
            return Regex.IsMatch(input, _domainNamePattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 输入字符串是否是identity card
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsIdentityCard(this string input)
        {
            return Regex.IsMatch(input, _identiyCardPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 输入字符串是否是ip
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsIp(this string input)
        {
            return Regex.IsMatch(input, _ipPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 输入字符串是否是qq
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsQq(this string input)
        {
            return Regex.IsMatch(input, _qqPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 输入字符串是否是date time
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsDateTime(this string input)
        {
            return Regex.IsMatch(input, _dateTimePattern, RegexOptions.IgnoreCase);
        }

    }
}
