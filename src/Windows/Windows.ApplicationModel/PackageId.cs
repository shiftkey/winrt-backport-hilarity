using System;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.ApplicationModel
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PackageId : IPackageId
	{
		public extern ProcessorArchitecture Architecture
		{
			get;
		}
		public extern string FamilyName
		{
			get;
		}
		public extern string FullName
		{
			get;
		}
		public extern string Name
		{
			get;
		}
		public extern string Publisher
		{
			get;
		}
		public extern string PublisherId
		{
			get;
		}
		public extern string ResourceId
		{
			get;
		}
		public extern PackageVersion Version
		{
			get;
		}
	}
}
