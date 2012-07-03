using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Guid(1298129231u, 47228, 16424, 188, 156, 89, 233, 148, 127, 176, 86), Version(100794368u)]
	public interface IPointerPointTransform
	{
		IPointerPointTransform Inverse
		{
			get;
		}
		bool TryTransform([In] Point inPoint, out Point outPoint);
		Rect TransformBounds([In] Rect rect);
	}
}
