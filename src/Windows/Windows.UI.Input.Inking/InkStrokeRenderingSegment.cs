using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class InkStrokeRenderingSegment : IInkStrokeRenderingSegment
	{
		public extern Point BezierControlPoint1
		{
			get;
		}
		public extern Point BezierControlPoint2
		{
			get;
		}
		public extern Point Position
		{
			get;
		}
		public extern float Pressure
		{
			get;
		}
		public extern float TiltX
		{
			get;
		}
		public extern float TiltY
		{
			get;
		}
		public extern float Twist
		{
			get;
		}
	}
}
