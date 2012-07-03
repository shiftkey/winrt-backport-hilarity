using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(PointerPoint)), Guid(2768659341u, 10778, 16702, 188, 117, 159, 56, 56, 28, 192, 105), Version(100794368u)]
	internal interface IPointerPointStatics
	{
		[DefaultOverload, Overload("GetCurrentPoint")]
		PointerPoint GetCurrentPoint([In] uint pointerId);
		[DefaultOverload, Overload("GetIntermediatePoints")]
		IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId);
		[Overload("GetCurrentPointTransformed")]
		PointerPoint GetCurrentPoint([In] uint pointerId, [In] IPointerPointTransform transform);
		[Overload("GetIntermediatePointsTransformed")]
		IVector<PointerPoint> GetIntermediatePoints([In] uint pointerId, [In] IPointerPointTransform transform);
	}
}
