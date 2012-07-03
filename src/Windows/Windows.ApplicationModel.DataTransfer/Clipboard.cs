using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Standard), Static(typeof(IClipboardStatics), 100794368u), Version(100794368u)]
	public static class Clipboard
	{
		public static extern event EventHandler<object> ContentChanged
		{
			add;
			remove;
		}
		public static extern DataPackageView GetContent();
		public static extern void SetContent([In] DataPackage content);
		public static extern void Flush();
		public static extern void Clear();
	}
}
