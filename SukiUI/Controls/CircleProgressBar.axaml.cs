using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SukiUI.Controls
{
	public partial class CircleProgressBar : UserControl
	{
		static CircleProgressBar()
		{
			HeightProperty.OverrideDefaultValue<CircleProgressBar>(150);
			WidthProperty.OverrideDefaultValue<CircleProgressBar>(150);
		}

		public CircleProgressBar()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public double Value
		{
			get { return GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		/// <summary>
		/// Defines the <see cref="Value"/> property.
		/// </summary>
		public static readonly StyledProperty<double> ValueProperty =
			AvaloniaProperty.Register<CircleProgressBar, double>(nameof(Value), defaultValue: 0, coerce: (o, d) => d * 3.6);

		public static readonly StyledProperty<double> StrokeWidthProperty =
		AvaloniaProperty.Register<CircleProgressBar, double>(nameof(StrokeWidth), defaultValue: 10);

		public double StrokeWidth
		{
			get { return GetValue(StrokeWidthProperty); }
			set { SetValue(StrokeWidthProperty, value); }
		}

		public static readonly StyledProperty<bool> IsIndeterminateProperty =
			AvaloniaProperty.Register<CircleProgressBar, bool>(nameof(IsIndeterminate), false);

		public bool IsIndeterminate
		{
			get => GetValue(IsIndeterminateProperty);
			set => SetValue(IsIndeterminateProperty, value);
		}
	}
}