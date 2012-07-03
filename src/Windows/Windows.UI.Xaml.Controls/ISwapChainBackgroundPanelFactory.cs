using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SwapChainBackgroundPanel)), Guid(427985364u, 51355, 18866, 137, 108, 89, 23, 191, 138, 220, 174), Version(100794368u), WebHostHidden]
	internal interface ISwapChainBackgroundPanelFactory
	{
		SwapChainBackgroundPanel CreateInstance([In] object outer, out object inner);
	}
}
