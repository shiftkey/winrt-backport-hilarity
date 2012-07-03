using System;
using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(1272641992u, 52658, 19147, 191, 195, 102, 72, 86, 51, 120, 236), Version(100794368u)]
	public interface IShareTargetActivatedEventArgs : IActivatedEventArgs
	{
		ShareOperation ShareOperation
		{
			get;
		}
	}
}
