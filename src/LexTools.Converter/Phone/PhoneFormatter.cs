using System;
using System.Text.RegularExpressions;

namespace LexTools.Converter.Phone
{
    public class PhoneFormatter : IPhoneFormatter
    {
        /// <summary>
        /// Convert to format like 1-818-111-1111
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string PhoneToFullForm(string phone)
        {
            if (phone.Length != 11)
            {
                throw new ArgumentException($"Phone {phone} format is invalid");
            }

            return $"{phone.Substring(0, 1)}-{phone.Substring(1, 3)}-{phone.Substring(4, 3)}-{phone.Substring(7)}";
        }

        public string GetOnlyDigits(string phone)
        {
            Regex nonDigitsRegex = new Regex("[^\\d]", RegexOptions.Compiled);
            if (string.IsNullOrEmpty(phone))
                return string.Empty;
            string result = nonDigitsRegex.Replace(phone, string.Empty);
            return result.TrimStart('0', '1');
        }

        /// <summary>
        /// Convert from format like 1-818-111-1111 to 18181111111
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string PhoneToDigits(string phone)
        {
            Regex nonDigitsRegex = new Regex("[^\\d]", RegexOptions.Compiled);
            if (string.IsNullOrEmpty(phone))
                return string.Empty;
            return nonDigitsRegex.Replace(phone, string.Empty);
        }

        /// <summary>
        /// Get phone part from phone like 1-818-111-1111
        /// </summary>
        /// <param name="phone"></param>
        /// <returns>normalized phone number like 8181111111</returns>
        public string GetPhonePart(string phone)
        {
            string digits = PhoneToDigits(phone);
            return digits.Length > 10 ?
                digits.Substring(phone.Length - 10, 10) :
                digits;
        }
    }
}
;