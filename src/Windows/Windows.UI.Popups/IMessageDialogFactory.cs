using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[ExclusiveTo(typeof(MessageDialog)), Guid(756422519u, 42607, 20133, 187, 135, 121, 63, 250, 73, 65, 242), Version(100794368u)]
	internal interface IMessageDialogFactory
	{
		MessageDialog Create([In] string content);
		MessageDialog CreateWithTitle([In] string content, [In] string title);
	}
}
