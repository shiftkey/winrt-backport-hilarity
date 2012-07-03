using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Guid(4224269862u, 41290, 19279, 130, 176, 51, 190, 217, 32, 175, 82), Version(100794368u)]
	public interface ILaunchActivatedEventArgs : IActivatedEventArgs
	{
		string Arguments
		{
			get;
		}
		string TileId
		{
			get;
		}
	}
}
