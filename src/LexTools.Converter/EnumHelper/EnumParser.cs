using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace LexTools.Converter.EnumHelper
{
    public static class EnumParser
    {
        public static TEnum ParseByDescription<TEnum>(string description)
        {
            dynamic type = typeof(TEnum);
            if (!type.IsEnum)
            {
                throw new ArgumentException();
            }
            FieldInfo[] fields = type.GetFields();
            dynamic field = fields.SelectMany(f => f.GetCustomAttributes(typeof(DescriptionAttribute), false), (f, a) => new {
                Field = f,
                Att = a
            }).SingleOrDefault(a => ((DescriptionAttribute)a.Att).Description.Equals(description, StringComparison.CurrentCultureIgnoreCase));

            if (field == null)
            {
                throw new ArgumentException();
            }
            return (TEnum)field.Field.GetRawConstantValue();
        }
    }
}