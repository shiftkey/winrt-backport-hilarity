using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[Guid(2431621289u, 31233, 18955, 159, 128, 160, 176, 187, 55, 15, 141), Version(100794368u)]
	public interface IBackgroundTransferContentPartFactory
	{
		BackgroundTransferContentPart CreateWithName([In] string name);
		BackgroundTransferContentPart CreateWithNameAndFileName([In] string name, [In] string fileName);
	}
}
