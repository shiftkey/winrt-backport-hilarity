using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GeneralTransform)), Guid(2049296688u, 10692, 20017, 182, 249, 222, 221, 82, 228, 223, 27), Version(100794368u), WebHostHidden]
	internal interface IGeneralTransformFactory
	{
		GeneralTransform CreateInstance([In] object outer, out object inner);
	}
}
