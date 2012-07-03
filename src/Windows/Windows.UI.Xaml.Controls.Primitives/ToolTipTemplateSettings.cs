using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ToolTipTemplateSettings : DependencyObject, IToolTipTemplateSettings
	{
		public extern double FromHorizontalOffset
		{
			get;
		}
		public extern double FromVerticalOffset
		{
			get;
		}
	}
}
