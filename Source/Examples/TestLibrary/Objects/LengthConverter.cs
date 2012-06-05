namespace TestLibrary
{
    using System;
    using System.ComponentModel;
    using System.Globalization;

    public class LengthConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string)) return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                var s = (string)value;
                return Length.Parse(s);
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}