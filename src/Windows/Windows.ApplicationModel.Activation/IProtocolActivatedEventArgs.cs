using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(1620440285u, 47040, 18091, 129, 254, 217, 15, 54, 208, 13, 36), Version(100794368u)]
	public interface IProtocolActivatedEventArgs : IActivatedEventArgs
	{
		Uri Uri
		{
			get;
		}
	}
}
