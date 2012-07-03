using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(KeyTimeHelper)), Guid(2141348140u, 8873, 17897, 154, 247, 199, 65, 110, 255, 247, 165), Version(100794368u), WebHostHidden]
	internal interface IKeyTimeHelperStatics
	{
		KeyTime FromTimeSpan([In] TimeSpan timeSpan);
	}
}
