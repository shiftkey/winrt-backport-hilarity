using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DoubleKeyFrame)), Guid(2895634115u, 30008, 16569, 177, 82, 105, 111, 127, 191, 71, 34), Version(100794368u), WebHostHidden]
	internal interface IDoubleKeyFrameFactory
	{
		DoubleKeyFrame CreateInstance([In] object outer, out object inner);
	}
}
