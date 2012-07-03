using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(Timeline)), Guid(492223239u, 48548, 18315, 138, 218, 235, 4, 213, 128, 205, 94), Version(100794368u), WebHostHidden]
	internal interface ITimelineFactory
	{
		Timeline CreateInstance([In] object outer, out object inner);
	}
}
