using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataRequestedEventArgs : IDataRequestedEventArgs
	{
		public extern DataRequest Request
		{
			get;
		}
	}
}
