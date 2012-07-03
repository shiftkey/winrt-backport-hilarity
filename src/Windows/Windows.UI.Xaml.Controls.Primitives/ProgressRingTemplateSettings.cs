using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ProgressRingTemplateSettings : DependencyObject, IProgressRingTemplateSettings
	{
		public extern double EllipseDiameter
		{
			get;
		}
		public extern Thickness EllipseOffset
		{
			get;
		}
		public extern double MaxSideLength
		{
			get;
		}
	}
}
