using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DurationHelper)), Guid(3163031870u, 13639, 20160, 181, 25, 255, 168, 249, 196, 131, 140), Version(100794368u), WebHostHidden]
	internal interface IDurationHelperStatics
	{
		Duration Automatic
		{
			get;
		}
		Duration Forever
		{
			get;
		}
		int Compare([In] Duration duration1, [In] Duration duration2);
		Duration FromTimeSpan([In] TimeSpan timeSpan);
		bool GetHasTimeSpan([In] Duration target);
		Duration Add([In] Duration target, [In] Duration duration);
		bool Equals([In] Duration target, [In] Duration value);
		Duration Subtract([In] Duration target, [In] Duration duration);
	}
}
