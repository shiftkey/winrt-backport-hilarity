using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GeneralTransform)), Guid(2691143863u, 41708, 16735, 173, 226, 234, 222, 147, 51, 242, 199), Version(100794368u), WebHostHidden]
	internal interface IGeneralTransform
	{
		GeneralTransform Inverse
		{
			get;
		}
		Point TransformPoint([In] Point point);
		bool TryTransform([In] Point inPoint, out Point outPoint);
		Rect TransformBounds([In] Rect rect);
	}
}
