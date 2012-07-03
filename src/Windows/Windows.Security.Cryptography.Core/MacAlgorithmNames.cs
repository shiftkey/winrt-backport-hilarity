using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMacAlgorithmNamesStatics), 100794368u), Version(100794368u)]
	public static class MacAlgorithmNames
	{
		public static extern string AesCmac
		{
			get;
		}
		public static extern string HmacMd5
		{
			get;
		}
		public static extern string HmacSha1
		{
			get;
		}
		public static extern string HmacSha256
		{
			get;
		}
		public static extern string HmacSha384
		{
			get;
		}
		public static extern string HmacSha512
		{
			get;
		}
	}
}
