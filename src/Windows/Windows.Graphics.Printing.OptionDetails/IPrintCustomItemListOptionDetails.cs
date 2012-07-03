using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[ExclusiveTo(typeof(PrintCustomItemListOptionDetails)), Guid(2784689544u, 22770, 20157, 185, 15, 81, 228, 242, 148, 76, 93), Version(100794368u)]
	internal interface IPrintCustomItemListOptionDetails : IPrintItemListOptionDetails, IPrintOptionDetails, IPrintCustomOptionDetails
	{
		void AddItem([In] string itemId, [In] string displayName);
	}
}
