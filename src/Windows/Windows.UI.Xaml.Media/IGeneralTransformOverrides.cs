using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GeneralTransform)), Guid(1326583939u, 9423, 17700, 144, 173, 138, 66, 177, 193, 39, 131), Version(100794368u), WebHostHidden]
	internal interface IGeneralTransformOverrides
	{
		GeneralTransform InverseCore
		{
			get;
		}
		bool TryTransformCore([In] Point inPoint, out Point outPoint);
		Rect TransformBoundsCore([In] Rect rect);
	}
}
