using Avalonia;
using Avalonia.Data.Converters;

using System.Globalization;

namespace SukiUI.Converters
{
    public class DoubleToThicknessConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is double length)
            {
                return new Thickness(length);
            }
            return new Thickness();
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Thickness thickness)
            {
                return Math.Max(thickness.Right, Math.Max(thickness.Left, Math.Max(thickness.Bottom, thickness.Top)));
            }
            return 0d;
        }
    }
}
