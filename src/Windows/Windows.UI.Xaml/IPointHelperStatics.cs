using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(PointHelper)), Guid(22727285u, 30424, 19326, 138, 51, 125, 121, 32, 70, 145, 238), Version(100794368u), WebHostHidden]
	internal interface IPointHelperStatics
	{
		Point FromCoordinates([In] float x, [In] float y);
	}
}
