using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ProgressBarTemplateSettings)), Guid(1071835690u, 58354, 19499, 148, 136, 145, 141, 119, 210, 187, 228), Version(100794368u), WebHostHidden]
	internal interface IProgressBarTemplateSettings
	{
		double ContainerAnimationEndPosition
		{
			get;
		}
		double ContainerAnimationStartPosition
		{
			get;
		}
		double EllipseAnimationEndPosition
		{
			get;
		}
		double EllipseAnimationWellPosition
		{
			get;
		}
		double EllipseDiameter
		{
			get;
		}
		double EllipseOffset
		{
			get;
		}
		double IndicatorLengthDelta
		{
			get;
		}
	}
}
