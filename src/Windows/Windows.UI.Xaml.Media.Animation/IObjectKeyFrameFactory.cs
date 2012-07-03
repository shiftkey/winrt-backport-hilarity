using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ObjectKeyFrame)), Guid(371594302u, 15981, 17624, 155, 154, 4, 174, 167, 15, 132, 146), Version(100794368u), WebHostHidden]
	internal interface IObjectKeyFrameFactory
	{
		ObjectKeyFrame CreateInstance([In] object outer, out object inner);
	}
}
