using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(ISwapChainBackgroundPanelFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SwapChainBackgroundPanel : Grid, ISwapChainBackgroundPanel
	{
		public extern SwapChainBackgroundPanel();
	}
}
