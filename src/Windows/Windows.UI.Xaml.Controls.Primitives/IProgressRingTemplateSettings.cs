using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ProgressRingTemplateSettings)), Guid(3115742700u, 50979, 17126, 131, 233, 152, 38, 39, 43, 220, 14), Version(100794368u), WebHostHidden]
	internal interface IProgressRingTemplateSettings
	{
		double EllipseDiameter
		{
			get;
		}
		Thickness EllipseOffset
		{
			get;
		}
		double MaxSideLength
		{
			get;
		}
	}
}
