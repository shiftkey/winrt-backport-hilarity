using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkStrokeRenderingSegment)), Guid(1750142751u, 35043, 18298, 162, 250, 86, 159, 95, 31, 155, 213), Version(100794368u)]
	internal interface IInkStrokeRenderingSegment
	{
		Point BezierControlPoint1
		{
			get;
		}
		Point BezierControlPoint2
		{
			get;
		}
		Point Position
		{
			get;
		}
		float Pressure
		{
			get;
		}
		float TiltX
		{
			get;
		}
		float TiltY
		{
			get;
		}
		float Twist
		{
			get;
		}
	}
}
