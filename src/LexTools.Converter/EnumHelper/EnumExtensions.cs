using System;
using System.ComponentModel;
using System.Linq;

namespace LexTools.Converter.EnumHelper
{
    public static class EnumExtensions
    {
        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static T ToEnum<T>(this int value) where T : struct
        {
            T enumValue = (T)Enum.ToObject(typeof(T), value);
            return enumValue;
        }

        public static string ToDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fieldInfo.GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static TEnum ToEnum<TEnum>(this string value, TEnum defaultValue)
             where TEnum : struct
        {
            TEnum result;
            if (Enum.TryParse(value, out result))
            {
                return result;
            }
            return defaultValue;
        }

        public static bool ContainsIn(this System.Enum value, params System.Enum[] values)
        {
            return values.Where(item => item.GetType() == value.GetType())
                .Any(item => Equals(item, value));
        }
    }
}
