using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VirtualizingPanel)), Guid(1593228669u, 26495, 16525, 169, 108, 177, 149, 7, 117, 4, 102), Version(100794368u), WebHostHidden]
	internal interface IVirtualizingPanelOverrides
	{
		void OnItemsChanged([In] object sender, [In] ItemsChangedEventArgs args);
		void OnClearChildren();
		void BringIndexIntoView([In] int index);
	}
}
