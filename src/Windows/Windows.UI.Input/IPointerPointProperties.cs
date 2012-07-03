using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(PointerPointProperties)), Guid(3348990539u, 49507, 20199, 128, 63, 103, 206, 121, 249, 151, 45), Version(100794368u)]
	internal interface IPointerPointProperties
	{
		Rect ContactRect
		{
			get;
		}
		Rect ContactRectRaw
		{
			get;
		}
		bool IsBarrelButtonPressed
		{
			get;
		}
		bool IsCanceled
		{
			get;
		}
		bool IsEraser
		{
			get;
		}
		bool IsHorizontalMouseWheel
		{
			get;
		}
		bool IsInRange
		{
			get;
		}
		bool IsInverted
		{
			get;
		}
		bool IsLeftButtonPressed
		{
			get;
		}
		bool IsMiddleButtonPressed
		{
			get;
		}
		bool IsPrimary
		{
			get;
		}
		bool IsRightButtonPressed
		{
			get;
		}
		bool IsXButton1Pressed
		{
			get;
		}
		bool IsXButton2Pressed
		{
			get;
		}
		int MouseWheelDelta
		{
			get;
		}
		float Orientation
		{
			get;
		}
		PointerUpdateKind PointerUpdateKind
		{
			get;
		}
		float Pressure
		{
			get;
		}
		bool TouchConfidence
		{
			get;
		}
		float Twist
		{
			get;
		}
		float XTilt
		{
			get;
		}
		float YTilt
		{
			get;
		}
		bool HasUsage([In] uint usagePage, [In] uint usageId);
		int GetUsageValue([In] uint usagePage, [In] uint usageId);
	}
}
