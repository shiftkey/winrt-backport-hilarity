using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IProgressBarFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IProgressBarStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ProgressBar : RangeBase, IProgressBar
	{
		public extern bool IsIndeterminate
		{
			get;
			set;
		}
		public extern bool ShowError
		{
			get;
			set;
		}
		public extern bool ShowPaused
		{
			get;
			set;
		}
		public extern ProgressBarTemplateSettings TemplateSettings
		{
			get;
		}
		public static extern DependencyProperty IsIndeterminateProperty
		{
			get;
		}
		public static extern DependencyProperty ShowErrorProperty
		{
			get;
		}
		public static extern DependencyProperty ShowPausedProperty
		{
			get;
		}
		public extern ProgressBar();
	}
}
