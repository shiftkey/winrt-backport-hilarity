using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(Clipboard)), Guid(3324502673u, 13538, 18787, 142, 237, 147, 203, 176, 234, 61, 112), Version(100794368u)]
	internal interface IClipboardStatics
	{
		event EventHandler<object> ContentChanged;
		DataPackageView GetContent();
		void SetContent([In] DataPackage content);
		void Flush();
		void Clear();
	}
}
