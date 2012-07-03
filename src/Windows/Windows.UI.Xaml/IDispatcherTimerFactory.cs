using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DispatcherTimer)), Guid(3918929518u, 13862, 16442, 175, 224, 4, 13, 88, 22, 86, 50), Version(100794368u), WebHostHidden]
	internal interface IDispatcherTimerFactory
	{
		DispatcherTimer CreateInstance([In] object outer, out object inner);
	}
}
