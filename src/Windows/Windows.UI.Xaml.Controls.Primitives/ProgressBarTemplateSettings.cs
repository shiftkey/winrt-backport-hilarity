using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ProgressBarTemplateSettings : DependencyObject, IProgressBarTemplateSettings
	{
		public extern double ContainerAnimationEndPosition
		{
			get;
		}
		public extern double ContainerAnimationStartPosition
		{
			get;
		}
		public extern double EllipseAnimationEndPosition
		{
			get;
		}
		public extern double EllipseAnimationWellPosition
		{
			get;
		}
		public extern double EllipseDiameter
		{
			get;
		}
		public extern double EllipseOffset
		{
			get;
		}
		public extern double IndicatorLengthDelta
		{
			get;
		}
	}
}
