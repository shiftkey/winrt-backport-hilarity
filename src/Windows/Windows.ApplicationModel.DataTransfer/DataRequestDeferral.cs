using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataRequestDeferral : IDataRequestDeferral
	{
		public extern void Complete();
	}
}
