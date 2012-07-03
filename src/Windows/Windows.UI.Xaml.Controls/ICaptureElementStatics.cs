using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(CaptureElement)), Guid(507743725u, 32166, 16542, 128, 110, 48, 90, 228, 173, 155, 63), Version(100794368u), WebHostHidden]
	internal interface ICaptureElementStatics
	{
		DependencyProperty SourceProperty
		{
			get;
		}
		DependencyProperty StretchProperty
		{
			get;
		}
	}
}
