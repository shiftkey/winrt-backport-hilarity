using System;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(CaptureElement)), Guid(832946407u, 62215, 19786, 182, 38, 233, 120, 134, 63, 91, 116), Version(100794368u), WebHostHidden]
	internal interface ICaptureElement
	{
		MediaCapture Source
		{
			get;
			set;
		}
		Stretch Stretch
		{
			get;
			set;
		}
	}
}
