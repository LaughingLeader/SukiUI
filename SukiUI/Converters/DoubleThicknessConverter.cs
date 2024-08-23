using Avalonia;
using Avalonia.Data.Converters;

using System;
using System.Globalization;

namespace SukiUI.Converters
{
    public class DoubleThicknessConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is double v)
            {
                return new Thickness(v);
            }
            return new Thickness();
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value is Thickness v)
            {
                return v.Left;
            }
            return 0;
        }
    }
}