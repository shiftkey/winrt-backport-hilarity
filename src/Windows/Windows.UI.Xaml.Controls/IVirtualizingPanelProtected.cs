using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(VirtualizingPanel)), Guid(3385436994u, 49714, 18333, 167, 201, 94, 118, 17, 25, 106, 69), Version(100794368u), WebHostHidden]
	internal interface IVirtualizingPanelProtected
	{
		void AddInternalChild([In] UIElement child);
		void InsertInternalChild([In] int index, [In] UIElement child);
		void RemoveInternalChildRange([In] int index, [In] int range);
	}
}
