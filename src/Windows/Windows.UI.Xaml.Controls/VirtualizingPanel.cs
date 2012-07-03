using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IVirtualizingPanelFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class VirtualizingPanel : Panel, IVirtualizingPanel, IVirtualizingPanelOverrides, IVirtualizingPanelProtected
	{
		public extern ItemContainerGenerator ItemContainerGenerator
		{
			get;
		}
		protected virtual extern void OnItemsChanged([In] object sender, [In] ItemsChangedEventArgs args);
		protected virtual extern void OnClearChildren();
		protected virtual extern void BringIndexIntoView([In] int index);
		protected extern void AddInternalChild([In] UIElement child);
		protected extern void InsertInternalChild([In] int index, [In] UIElement child);
		protected extern void RemoveInternalChildRange([In] int index, [In] int range);
	}
}
