using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(FlipView)), Guid(4057901502u, 39656, 19787, 171, 67, 22, 211, 30, 5, 244, 243), Version(100794368u), WebHostHidden]
	internal interface IFlipViewFactory
	{
		FlipView CreateInstance([In] object outer, out object inner);
	}
}
