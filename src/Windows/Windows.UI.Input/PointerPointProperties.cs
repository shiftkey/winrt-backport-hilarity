using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class PointerPointProperties : IPointerPointProperties
	{
		public extern Rect ContactRect
		{
			get;
		}
		public extern Rect ContactRectRaw
		{
			get;
		}
		public extern bool IsBarrelButtonPressed
		{
			get;
		}
		public extern bool IsCanceled
		{
			get;
		}
		public extern bool IsEraser
		{
			get;
		}
		public extern bool IsHorizontalMouseWheel
		{
			get;
		}
		public extern bool IsInRange
		{
			get;
		}
		public extern bool IsInverted
		{
			get;
		}
		public extern bool IsLeftButtonPressed
		{
			get;
		}
		public extern bool IsMiddleButtonPressed
		{
			get;
		}
		public extern bool IsPrimary
		{
			get;
		}
		public extern bool IsRightButtonPressed
		{
			get;
		}
		public extern bool IsXButton1Pressed
		{
			get;
		}
		public extern bool IsXButton2Pressed
		{
			get;
		}
		public extern int MouseWheelDelta
		{
			get;
		}
		public extern float Orientation
		{
			get;
		}
		public extern PointerUpdateKind PointerUpdateKind
		{
			get;
		}
		public extern float Pressure
		{
			get;
		}
		public extern bool TouchConfidence
		{
			get;
		}
		public extern float Twist
		{
			get;
		}
		public extern float XTilt
		{
			get;
		}
		public extern float YTilt
		{
			get;
		}
		public extern bool HasUsage([In] uint usagePage, [In] uint usageId);
		public extern int GetUsageValue([In] uint usagePage, [In] uint usageId);
	}
}
