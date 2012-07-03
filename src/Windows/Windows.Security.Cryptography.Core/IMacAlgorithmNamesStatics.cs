using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(MacAlgorithmNames)), Guid(1094788728u, 64286, 17316, 137, 94, 169, 2, 110, 67, 144, 163), Version(100794368u)]
	internal interface IMacAlgorithmNamesStatics
	{
		string AesCmac
		{
			get;
		}
		string HmacMd5
		{
			get;
		}
		string HmacSha1
		{
			get;
		}
		string HmacSha256
		{
			get;
		}
		string HmacSha384
		{
			get;
		}
		string HmacSha512
		{
			get;
		}
	}
}
