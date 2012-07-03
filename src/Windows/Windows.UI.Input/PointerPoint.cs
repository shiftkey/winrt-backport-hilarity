using System;
using System.Runtime.InteropServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.None), Static(typeof(IPointerPointStatics), 100794368u), Version(100794368u)]
	public sealed class PointerPoint : IPointerPoint
	{
		public extern uint FrameId
		{
			get;
		}
		public extern bool IsInContact
		{
			get;
		}
		public extern PointerDevice PointerDevice
		{
			get;
		}
		public extern uint PointerId
		{
			get;
		}
		public extern Point Position
		{
			get;
		}
		public extern PointerPointProperties Properties
		{
			get;
		}
		public extern Point RawPosition
		{
			get;
		}
		public extern ulong Timestamp
		{
			get;
		}
		[DefaultOverload, Overload("GetCurrentPoint")]
		public static extern PointerPoint GetCurrentPoint([In] uint pointerId);
		[DefaultOverload, Overload("GetIntermediatePoints")]
		public static extern IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId);
		[Overload("GetCurrentPointTransformed")]
		public static extern PointerPoint GetCurrentPoint([In] uint pointerId, [In] IPointerPointTransform transform);
		[Overload("GetIntermediatePointsTransformed")]
		public static extern IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId, [In] IPointerPointTransform transform);
	}
}
