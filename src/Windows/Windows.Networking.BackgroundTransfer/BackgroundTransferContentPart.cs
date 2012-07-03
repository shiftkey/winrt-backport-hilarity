using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Networking.BackgroundTransfer
{
	[Activatable(typeof(IBackgroundTransferContentPartFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BackgroundTransferContentPart : IBackgroundTransferContentPart
	{
		public extern BackgroundTransferContentPart([In] string name);
		public extern BackgroundTransferContentPart([In] string name, [In] string fileName);
		public extern BackgroundTransferContentPart();
		public extern void SetHeader([In] string headerName, [In] string headerValue);
		public extern void SetText([In] string value);
		public extern void SetFile([In] IStorageFile value);
	}
}
