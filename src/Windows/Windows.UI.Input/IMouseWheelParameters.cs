using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(MouseWheelParameters)), Guid(3939551812u, 40429, 16439, 129, 73, 94, 76, 194, 86, 68, 104), Version(100794368u)]
	internal interface IMouseWheelParameters
	{
		Point CharTranslation
		{
			get;
			set;
		}
		float DeltaRotationAngle
		{
			get;
			set;
		}
		float DeltaScale
		{
			get;
			set;
		}
		Point PageTranslation
		{
			get;
			set;
		}
	}
}
