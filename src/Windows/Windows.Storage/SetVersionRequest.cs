using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SetVersionRequest : ISetVersionRequest
	{
		public extern uint CurrentVersion
		{
			get;
		}
		public extern uint DesiredVersion
		{
			get;
		}
		public extern SetVersionDeferral GetDeferral();
	}
}
