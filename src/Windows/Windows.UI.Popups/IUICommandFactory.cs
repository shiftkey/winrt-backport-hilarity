using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[ExclusiveTo(typeof(UICommand)), Guid(2719646089u, 9904, 18038, 174, 148, 84, 4, 27, 193, 37, 232), Version(100794368u)]
	internal interface IUICommandFactory
	{
		UICommand Create([In] string label);
		UICommand CreateWithHandler([In] string label, [In] UICommandInvokedHandler action);
		UICommand CreateWithHandlerAndId([In] string label, [In] UICommandInvokedHandler action, [Variant] [In] object commandId);
	}
}
